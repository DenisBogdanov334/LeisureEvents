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

namespace Cafeteria
{
    public partial class Cafeteria : Form
    {
        private RFID rfid;
        private DataHelper dh;
        private List<Order> orderedProducts;
        private Customer tempCustomer;
        private List<int> stores;
        public Cafeteria()
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
            orderedProducts = new List<Order>();
            stores = new List<int>();
            try
            {
                stores.AddRange(dh.GetStores());
                foreach(int id in stores)
                {
                    comboBoxStoreId.Items.Add(id);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            try
            {
                PopulateMenuMainCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                tempCustomer = dh.GetCustomer(rfidNr);
                if (orderedProducts.Capacity != 0)
                {
                    if (tempCustomer.CustomerBalance >= this.CalculateTotalBill())
                    {
                        btnProceedOrder.Enabled = true;
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

        private void PopulateMenuMainCourse()
        {
            foreach (Product p in dh.PopulateMenu())
            {
                if(p.ProductCategory == "Main Course")
                {
                    dataGridViewMenu.Rows.Add(p.ProductID, p.ProductName, p.ProductPrice);
                    groupBoxCategory.Text = "Main Course";
                }
                
            }
        }
        private void PopulateMenuDesserts()
        {
            foreach (Product p in dh.PopulateMenu())
            {
                if (p.ProductCategory == "Desserts")
                {
                    dataGridViewMenu.Rows.Add(p.ProductID, p.ProductName, p.ProductPrice);
                    groupBoxCategory.Text = "Desserts";
                }
                
            }
        }
        private void PopulateMenuBeverages()
        {
            foreach (Product p in dh.PopulateMenu())
            {
                if (p.ProductCategory == "Beverages")
                {
                    dataGridViewMenu.Rows.Add(p.ProductID, p.ProductName, p.ProductPrice);
                    groupBoxCategory.Text = "Beverages";
                }
                
            }
        }

        public decimal CalculateTotalBill()
        {
            decimal totalBill = 0;
            for (int i = 0; i < dataGridViewBill.Rows.Count; i++)
            {
                totalBill += Convert.ToDecimal(dataGridViewBill.Rows[i].Cells["ColumnTotal"].Value);
            }
            return totalBill;
        }



        //select product from the menu and display it in the bill and add it to the list
        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewBill.ClearSelection();
            numericUpDownQty.Value = 1;
            try
            {
                foreach (DataGridViewRow dr in dataGridViewMenu.SelectedRows)
                {
                    int selectedProductId = Convert.ToInt32(dr.Cells["ColumnProductId"].Value);
                    string selectedProductName = dr.Cells["ColumnProductName"].Value.ToString();
                    decimal selectedProductPrice = Convert.ToDecimal(dr.Cells["ColumnProductPrice"].Value);
                    int quantity = 1;
                    Order addProduct = new Order(selectedProductId, selectedProductName, selectedProductPrice, quantity);
                    orderedProducts.Add(addProduct);
                    dataGridViewBill.Rows.Add(addProduct.ProductName, addProduct.ProductPrice, addProduct.Quantity, addProduct.TotalPerProduct);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select product first!");
            }
            lbTotalPrice.Text = "Total price: €" + this.CalculateTotalBill().ToString("0.00");
        }


        private void numericUpDownQty_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewBill.SelectedRows)
                {

                    int newQuantity = Convert.ToInt32(numericUpDownQty.Value);
                    Order selectedProduct = orderedProducts[row.Index];

                    row.Cells["ColumnQty"].Value = newQuantity;
                    selectedProduct.ChangeTotalProduct(newQuantity);
                    row.Cells["ColumnTotal"].Value = selectedProduct.TotalPerProduct;

                }
                lbTotalPrice.Text = "Total price: €" + this.CalculateTotalBill().ToString("0.00");

            }

            catch (Exception)
            {
                MessageBox.Show("Please select product first!");
            }
        }

        private void btnRemoveSelectedProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBill.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridViewBill.SelectedCells[0].RowIndex;
                    dataGridViewBill.Rows.RemoveAt(selectedRowIndex);
                    orderedProducts.Remove((Order)orderedProducts[selectedRowIndex]);
                }

                lbTotalPrice.Text = "Total price: €" + this.CalculateTotalBill().ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Please select product first!");
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the order?", "Cancel order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RefreshApp();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void btnProceedOrder_Click(object sender, EventArgs e)
        {
            tempCustomer.GetNewBalance(this.CalculateTotalBill());
            try
            {
                if(comboBoxStoreId.Text != "")
                {
                    dh.UpdateCustomerTable(tempCustomer.CustomerId, tempCustomer.CustomerBalance);
                    dh.UpdateStore(Convert.ToInt32(comboBoxStoreId.SelectedItem), this.CalculateTotalBill());
                    foreach(Order o in orderedProducts)
                    {
                        dh.UpdateProductTable(o.ProdictId, o.Quantity);
                    }

                    MessageBox.Show("Order successful!");
                    RefreshApp();
                }
                else
                {
                    MessageBox.Show("Please select store!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rfid.Close();
            dh.connection.Close();
        }
        private void RefreshApp()
        {
            dataGridViewMenu.Rows.Clear();
            try
            {
                PopulateMenuMainCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            orderedProducts = new List<Order>();
            tempCustomer = null;
            dataGridViewBill.Rows.Clear();
            btnProceedOrder.Enabled = false;
            lbTotalPrice.Text = "Total price ---";
            numericUpDownQty.Value = 1;
        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            dataGridViewMenu.Rows.Clear();
            try
            {
                PopulateMenuMainCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDessets_Click(object sender, EventArgs e)
        {
            dataGridViewMenu.Rows.Clear();
            try
            {
                PopulateMenuDesserts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            dataGridViewMenu.Rows.Clear();
            try
            {
                PopulateMenuBeverages();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
