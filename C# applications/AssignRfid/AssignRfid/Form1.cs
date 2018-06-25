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

namespace AssignRfid
{
    public partial class Form1 : Form
    {
        private RFID rfid;
        private DataHelper dh;
        Customer tempCustomer;

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

            dh = new DataHelper();
            dh.connection.Open();
        }

        private void Rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {

        }

        private void Rfid_Tag(object sender, RFIDTagEventArgs e)
        {
            string rfid = e.Tag;
            if(tempCustomer != null)
            {
                try
                {
                    tempCustomer.AssignRfid(rfid);
                    dh.InsertCustomerRfidTable(tempCustomer.Id, tempCustomer.Rfid);
                    ShowInfo(tempCustomer);
                    MessageBox.Show("Successful update");
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message + " RFID not assigned!");
                    listBoxInfo.Items.Clear();
                    tempCustomer = null;
                    rfid = null;
                }
            }
            else
            {
                MessageBox.Show("No visitor selected");
            }
        }

        private void Rfid_Detach(object sender, DetachEventArgs e)
        {
            MessageBox.Show("Reader is detached!");
        }

        private void Rfid_Attach(object sender, AttachEventArgs e)
        {

        }

        private void ShowInfo(Customer tempCustomer)
        {
            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("Vistor ID: " + tempCustomer.Id);
            if (tempCustomer.Rfid != null)
            {
                listBoxInfo.Items.Add("Visitor's Rfid Number: " + tempCustomer.Rfid);
            }
            listBoxInfo.Items.Add("Name: " + tempCustomer.FirstName + " " + tempCustomer.LastName);
            listBoxInfo.Items.Add("Address: " + tempCustomer.Address);
        }

        private void btnNextCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                tempCustomer = dh.GetCustomer();
                ShowInfo(tempCustomer);
            }
            catch (Exception ex)
            {
                listBoxInfo.Items.Clear();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                string info = "Name: " + tempCustomer.FirstName + " " + tempCustomer.LastName + "\r\n" + "Address: " + tempCustomer.Address;
                e.Graphics.DrawString(info, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
            }
            catch(Exception)
            {
                MessageBox.Show("Document not found!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                tempCustomer = dh.GetCustomer();
                ShowInfo(tempCustomer);
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rfid.Close();
            dh.connection.Close();
        }
    }
}
