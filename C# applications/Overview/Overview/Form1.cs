using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overview
{
    public partial class Form1 : Form
    {
        private DataHelper dh;
        private int customerId;
        
        public Form1()
        {
            InitializeComponent();
            try
            {
                dh = new DataHelper();
                dh.connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection to database failed");
            }
        }

        private void btnVisitorStatus_Click(object sender, EventArgs e)
        {
            try
            {
                customerId = Convert.ToInt32(txtbVisitorId.Text);
                Customer tempCustomer = dh.GetCustomerStatus(customerId);
                listBoxInfo.Items.Clear();
                listBoxInfo.Items.Add(tempCustomer.StatusString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVisitorHistory_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            try
            {
                customerId = Convert.ToInt32(txtbVisitorId.Text);
                List<Customer> customerHistory = new List<Customer>();
                customerHistory = dh.GetCustomerHistory(customerId);
                
                foreach(Customer c in customerHistory)
                {
                    listBoxInfo.Items.Add(c.CustomerHistoryString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVisitorsPresent_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            try
            {
                int present = dh.GetVisitorsPresent();
                listBoxInfo.Items.Add("Number of the visitors present: " + present);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVisitorsTotal_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            try
            {
                int all = dh.GetVisitorsRegistered();
                listBoxInfo.Items.Add("Number of registered visitors : " + all);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTotalBalanceVisitors_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            try
            {
                decimal totalBalance = dh.GetTotalBalanceVisitors();
                listBoxInfo.Items.Add("The total balance of all visitors is : €" + totalBalance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTotalPerShop_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            try
            {
                int storeId = Convert.ToInt32(txtbShopProductId.Text);
                decimal profitShop = dh.GetProfitPerStore(storeId);
                listBoxInfo.Items.Add("The total profit for shop with ID " + storeId + ": €" + profitShop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTotalAmountProduct_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            try
            {
                int productId = Convert.ToInt32(txtbShopProductId.Text);
                int amountProduct = dh.GetAmountProduct(productId);
                listBoxInfo.Items.Add("The total amount sold of product with ID " + productId + ": " + amountProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBookedSpots_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            List<string> bookedSpots = new List<string>();
            try
            {
                bookedSpots = dh.GetBookedSpots();
                listBoxInfo.Items.Add("The number of booked spots: " + bookedSpots.Count);
                listBoxInfo.Items.Add("The booked spots are:");
                foreach(string s in bookedSpots)
                {
                    listBoxInfo.Items.Add("SpotID: " + s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnFreeSpots_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            try
            {
                int freeSpots = dh.GetFreeSpots();
                listBoxInfo.Items.Add("The number of free spots: " + freeSpots);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTotalMoneySpent_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            try
            {
                decimal moneySpent = dh.GetMoneySpent();
                listBoxInfo.Items.Add("The total money spent from all the visitors: €" + moneySpent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            dh.connection.Close();
        }

        private void btnShowLoanedProducts_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            try
            {
                List<LoanedProduct> loanedPr = dh.GetLoanedProducts();
                foreach(LoanedProduct lp in loanedPr)
                {
                    listBoxInfo.Items.Add("Product: " + lp.NameProduct + " -- Amount borrowed: " + lp.AmountBorrowed);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLoanProfit_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            try
            {
                int standId = Convert.ToInt32(txtbLoanStandId.Text);
                decimal profitStand = dh.GetProfitPerStand(standId);
                listBoxInfo.Items.Add("The total profit for stand with ID " + standId + ": €" + profitStand);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
