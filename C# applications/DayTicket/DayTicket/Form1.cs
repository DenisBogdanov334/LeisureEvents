using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DayTicket
{
    public partial class Form1 : Form
    {
        private DataHelper dh;
        private Customer addCustomer;
        public Form1()
        {
            InitializeComponent();

            try { dh = new DataHelper(); }
            catch (Exception e) { MessageBox.Show("Connection with database failed: " + e.Message); }
        }

        public void AddCustomer()
        {
            string fName = txtbFirstName.Text.ToString();
            string lName = txtbLastName.Text.ToString();
            string email = txtbEmail.Text.ToString();
            string phone = txtbPhone.Text.ToString();


            addCustomer = new Customer(fName, lName, email, phone);
        }


        private void btnProceed_Click(object sender, EventArgs e)
        {
            dh.connection.Open();
            AddCustomer();
            panelInfo.Visible = false;
            panelPaymentDetails.Visible = true;
            panelPaymentDetails.Location = new Point(50, 60);
            lbName.Text = txtbFirstName.Text.ToString() + " " + txtbLastName.Text.ToString();
            lbDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }

        private string GetAccountNum()
        {
            string bankAccNr = txtbBankAccount.Text.ToString();
            string accountNum = bankAccNr.Substring(bankAccNr.Length - 4);
            return accountNum;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

            try
            {
                dh.InsertCustomerTable(addCustomer, GetAccountNum());
                dh.connection.Close();
                Form2 assignRfidForm = new Form2();
                this.Hide();
                assignRfidForm.Show();
            }
                            
            catch (Exception e4)
            {
                MessageBox.Show("Unsuccessful registration: " + e4.Message);
            }
        }

        private void AssignRfidForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtbFirstName.Clear();
            txtbLastName.Clear();
            txtbEmail.Clear();
            txtbPhone.Clear();
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            dh.connection.Close();
        }
    }
}
