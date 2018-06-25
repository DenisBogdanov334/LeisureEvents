using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Phidget22;
using Phidget22.Events;

namespace CheckInOutEvent
{
    public partial class CheckInOut : Form
    {
        private RFID rfid;
        private DataHelper dh;
        public CheckInOut()
        {
            InitializeComponent();

            try
            {
                rfid = new RFID();
                rfid.Attach += Rfid_Attach;
                rfid.Detach += Rfid_Detach;
                rfid.Tag += Rfid_Tag;
                rfid.TagLost += Rfid_TagLost;

                rfid.Open();
            }

            catch (PhidgetException)
            {
                MessageBox.Show("Error");
            }

            try
            {
                dh = new DataHelper();
                dh.connection.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("Connection with database unsuccessful: " + e.Message);
            }

        }

        private void Rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            lbChecked.ForeColor = Color.Black;
            lbChecked.Text = "Next visitor";
        }

        private void Rfid_Tag(object sender, RFIDTagEventArgs e)
        {
            string rfidNr = e.Tag;
            Customer c = null;
            try { c = dh.GetCustomer(rfidNr); }
            catch(Exception e1) { MessageBox.Show(e1.Message); }
            if (c != null)
            {
                if (c.CheckedStatusEvent == 0)
                {
                    lbChecked.Text = "Welcome, " + c.FirstName + " " + c.LastName + " !";
                    try
                    {
                        dh.UpdateCustomertable();
                        dh.InsertCustomerHistory();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show("Error updating database: " + e2.Message);
                    }
                }
                else
                {
                    if(c.LoanedProductStatus == 0)
                    {
                        lbChecked.Text = "Goodbye, " + c.FirstName + " " + c.LastName + " !";
                        try
                        {
                            dh.UpdateCustomertable();
                            dh.InsertCustomerHistory();
                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show("Error updating database: " + e2.Message);
                        }
                    }
                    else
                    {
                        lbChecked.ForeColor = Color.Red;
                        lbChecked.Text = "Please return the loaned products first!";
                    }
                }
                
            }
            
            
        }
        private void Rfid_Detach(object sender, DetachEventArgs e)
        {
            MessageBox.Show("Reader is detached!");
        }

        private void Rfid_Attach(object sender, AttachEventArgs e)
        {
            
        }
        private void CheckInOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            rfid.Close();
            dh.connection.Close();
        }
    }
}
