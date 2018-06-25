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


namespace CheckInOutCamping
{
    public partial class Form1 : Form
    {
        private RFID rfid;
        private DataHelper dh;
        public Form1()
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
            catch(Exception e) { MessageBox.Show("Connection with database unsuccessful: " + e.Message); }
        }

        private void Rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Next visitor!";
            listBoxInfo.Items.Clear();
        }

        private void Rfid_Tag(object sender, RFIDTagEventArgs e)
        {
            string rfidNr = e.Tag;
            Customer c = null;
            try { c = dh.GetCustomer(rfidNr); }
            catch(Exception e1) { MessageBox.Show(e1.Message); }

            if (c != null)
            {
                if (c.Reservation == true)
                {
                    if (c.CheckedStatusCamp == 0)
                    {
                        listBoxInfo.Items.Add("Welcome, " + c.FirstName + " " + c.LastName + " !");
                        listBoxInfo.Items.Add("Your SpotID is: " + c.SpotId);
                        label1.Text = "We wish you a plesant stay!";
                    }
                    else
                    {
                        label1.Visible = false;
                        listBoxInfo.Items.Add("Goodbye, " + c.FirstName + " " + c.LastName + " !");
                    }
                    try { dh.UpdateCustomertable(); }
                    catch(Exception e2) { MessageBox.Show(e2.Message); }
                }
                else
                {
                    label1.Text = "No reservation found!";
                }
            }
        }

        private void Rfid_Detach(object sender, DetachEventArgs e)
        {
            MessageBox.Show("Reader detached!");
        }

        private void Rfid_Attach(object sender, AttachEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            rfid.Close();
            dh.connection.Close();
        }
    }
}
