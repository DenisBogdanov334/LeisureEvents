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



namespace LoanStand
{
    public partial class Form1 : Form
    {
        private RFID rfid;
        private Data d;
        private List<Loan> loan;
        private Customer c;
        private List<int> stands;
        private Loan l;
        
        public Form1()
        {
            InitializeComponent();
            try { d = new Data();  d.connection.Open(); }
            catch (Exception) { }

            try
            {
                stands = new List<int>();
                stands.AddRange(d.GetStores());
                foreach (int id in stands)
                {
                    comboBox1.Items.Add(id);
                }
            }
            catch (Exception) { }

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
            

            loan = new List<Loan>();
            
            try
            {
                foreach (Product p82 in d.Products())
                {
                    items.Rows.Add(p82.ID, p82.Name, p82.PricePerDay);
                }
            }
            catch (Exception)
            {
                
            }


        }

        private void Rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            
        }

        private void Rfid_Tag(object sender, RFIDTagEventArgs e)
        {
            string rfidNr = e.Tag;

            try
            {
                c = d.Customer(rfidNr);
                if (loan.Capacity != 0)
                {
                    if (c.CustomerBalance >= this.CalculateTotal())
                    {
                        borrow.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Balance not enough!");
                    }
                }
                else
                {
                    MessageBox.Show("No order found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Rfid_Detach(object sender, DetachEventArgs e)
        {
            MessageBox.Show("Reader detached!");
        }

        private void Rfid_Attach(object sender, AttachEventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in bill.SelectedRows)
                {
                    int qty = Convert.ToInt32(numericUpDownQty.Value);
                    int days = Convert.ToInt32(numericUpDownDays.Value);
                    Loan product = loan[row.Index];
                    row.Cells["qty"].Value = qty;
                    product.ChangeTotalProduct(qty, days);
                    row.Cells["total"].Value = product.TotalPerProduct;
                    
                }
                textBox1.Text = "€ " + CalculateTotal().ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Please select product first!");
            }
        }

        private void borrow_Click(object sender, EventArgs e)
        {
            c.GetNewBalance(CalculateTotal());
            try
            {
                if (comboBox1.Text != "")
                {
                    d.EventAccount(c.CustomerId, c.CustomerBalance);
                    d.Stand(Convert.ToInt32(comboBox1.Text), CalculateTotal());
                    d.UpdateCustomerLoanedTrue(c.CustomerId);
                    foreach (Loan l in loan)
                    {
                        d.Product(l.ID, l.Qty);
                    }
                    MessageBox.Show("Successful");
                    try
                    {
                        items.Rows.Clear();
                        foreach (Product p82 in d.Products())
                        {
                            items.Rows.Add(p82.ID, p82.Name, p82.PricePerDay);
                        }
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show(e2.Message);
                    }
                    loan = new List<Loan>();
                    c = null;
                    
                    bill.Rows.Clear();
                   
                    textBox1.Text = "";
                    numericUpDownQty.Value = 1;
                    numericUpDownDays.Value = 1;
                    borrow.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please select stand");
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                foreach (DataGridViewRow dr in items.SelectedRows)
                {

                    int id = Convert.ToInt32(dr.Cells["ProductID"].Value);
                    string name = dr.Cells["Productname"].Value.ToString();
                    decimal priceperday = Convert.ToDecimal(dr.Cells["Priceperday"].Value);
                    int qty = Convert.ToInt32(numericUpDownQty.Value);
                    int days = Convert.ToInt32(numericUpDownDays.Value);
                    l = new Loan(id, name, priceperday, qty, days);

                    
                    loan.Add(l);
                    bill.Rows.Add(l.Name, l.PricePerDay, l.Qty, l.Days, l.TotalPerProduct);

                    textBox1.Text = "€" + this.CalculateTotal().ToString();
                }
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please select product first!");
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(bill.Rows.Count>0)
                {
                    int i = bill.SelectedCells[0].RowIndex;
                    bill.Rows.RemoveAt(i);
                    loan.Remove((Loan)loan[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select product first!");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the order?", "Cancel order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                loan = new List<Loan>();
                c = null;
                textBox1.Text = "";
                numericUpDownQty.Value = 1;
                numericUpDownDays.Value = 1;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach(Loan l in loan)
            {
                total += l.TotalPerProduct;
            }
            return total;
        }

        private void bill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDownDays_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in bill.SelectedRows)
                {
                    int qty = Convert.ToInt32(numericUpDownQty.Value);
                    int days = Convert.ToInt32(numericUpDownDays.Value);
                    Loan product = loan[row.Index];
                    row.Cells["days"].Value = days;
                    product.ChangeTotalProduct(qty,days);
                    row.Cells["total"].Value = product.TotalPerProduct;

                }
                textBox1.Text = "€" + CalculateTotal().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select product first!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rfid.Close();
            d.connection.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            try
            {
                int pId = Convert.ToInt32(txtbProductIdReturn.Text);
                int amount = Convert.ToInt32(txtbAmountReturn.Text);
                d.ReturnProduct(pId, amount);
                d.UpdateCustomerLoanedFalse(c.CustomerId);
                MessageBox.Show("Product returned!");
                txtbProductIdReturn.Clear();
                txtbAmountReturn.Clear();
            }
            catch(Exception e1)
            {
                MessageBox.Show("Couldn't return product: " + e1.Message);
            }
        }
    }
            
           
        
          
}
