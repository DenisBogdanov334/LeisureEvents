using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace DayTicket
{
    public partial class Form2 : Form
    {
        private DataHelper dh;
        private RFID rfid;
        private Customer customer;

        public Form2()
        {
            
            InitializeComponent();
            try { dh = new DataHelper(); dh.connection.Open(); }
            catch (Exception e) { MessageBox.Show("Connection with database failed: " + e.Message); }
            try { customer = dh.GetCustomerInfo(); }
            catch (Exception e3) { MessageBox.Show(e3.Message); }
            this.ShowInfo();
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
            dh.connection.Close();
        }

        private void Rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            dh.connection.Close();
        }

        private void Rfid_Tag(object sender, RFIDTagEventArgs e)
        {
            
            string rfidNr = e.Tag;
            try
            {
                dh.connection.Open();
                dh.InsertCustomerRfidTable(rfidNr);
                MessageBox.Show("Successful update");
                ShowInfo();
                dh.connection.Close();
            }
            catch(Exception e1)
            {
                dh.connection.Close();
                MessageBox.Show("Error updating the customerrfid table: " + e1.Message);
            }
        }

        private void Rfid_Detach(object sender, DetachEventArgs e)
        {
            MessageBox.Show("Reader detached!");
        }

        private void Rfid_Attach(object sender, AttachEventArgs e)
        {
            
        }

        private void ShowInfo()
        {
            listBoxInfo.Items.Clear();
            if(customer != null)
            {
                listBoxInfo.Items.Add("Visitor ID: " + customer.Id);
                listBoxInfo.Items.Add("Name: " + customer.FirstName + " " + customer.LastName);
            }
        }

        private void btnNextVisitor_Click(object sender, EventArgs e)
        {
            dh.connection.Close();
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            
        }
    }
}
