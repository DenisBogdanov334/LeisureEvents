using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Cafeteria
{
    class DataHelper
    {
        public MySqlConnection connection;
        int customerId = 0;
        decimal customerBalance = 0;

        public DataHelper()
        {
            String connectionInfo = "server = studmysql01.fhict.local;" + "database=dbi362350;"
            + "userid=dbi362350;" + "password=123123;";

            connection = new MySqlConnection(connectionInfo);

        }

        public int GetCustomerID(string rfid)
        {
            int custId = 0;
            string sql = "SELECT * FROM customerrfid WHERE RfidNr=@rfid";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@rfid", rfid);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    custId = Convert.ToInt32(reader["CustomerID"]);
                }
                reader.Close();
            }
            else
            {
                reader.Close();
                throw new ThrowException("Rfid not found!");
            }
            return custId;
        }

        public Customer GetCustomer(string rfid)
        {

            string sqlGetId = "SELECT * FROM customer WHERE CustomerID = @id";
            MySqlCommand command = new MySqlCommand(sqlGetId, connection);
            command.Parameters.AddWithValue("@id", GetCustomerID(rfid));
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    customerId = Convert.ToInt32(reader["CustomerID"]);
                    customerBalance = Convert.ToDecimal(reader["Balance"]);
                }
                reader.Close();
            }

            else
            {
                reader.Close();
                throw new ThrowException("Customer not found!");

            }


            Customer tempCustomer = new Customer(customerId, customerBalance);
            return tempCustomer;
        }


        public List<int> GetStores()
        {
            List<int> stores = new List<int>();
            string sqlStore = "SELECT * FROM profitloan";
            MySqlCommand command = new MySqlCommand(sqlStore, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int storeId = Convert.ToInt32(reader["LoanStoreID"]);
                stores.Add(storeId);
            }
            reader.Close();

            return stores;
        }


        public void UpdateStore(int storeId, decimal addToProfit)
        {
            MySqlCommand update;

            string queryUpdateStore = "UPDATE buystore SET Profit = Profit + @billTotal WHERE StoreID = @storeId";
            update = new MySqlCommand(queryUpdateStore, connection);
            update.Parameters.AddWithValue("@billTotal", addToProfit);
            update.Parameters.AddWithValue("@storeID", storeId);
            update.ExecuteNonQuery();
        }
        public void UpdateCustomerTable(int customerId, decimal newBalance)
        {
            MySqlCommand update;

            string queryChangeBalance = "UPDATE customer SET Balance = @newBalance WHERE CustomerID = @customerId";
            update = new MySqlCommand(queryChangeBalance, connection);
            update.Parameters.AddWithValue("@newBalance", newBalance);
            update.Parameters.AddWithValue("@customerId", customerId);
            update.ExecuteNonQuery();
        }

        public void UpdateProductTable(int productId, int amountSold)
        {
            MySqlCommand update;

            string queryUpdateProduct = "UPDATE buyproduct SET AmountSold = AmountSold + @amount WHERE ProductID = @productId";
            update = new MySqlCommand(queryUpdateProduct, connection);
            update.Parameters.AddWithValue("@amount", amountSold);
            update.Parameters.AddWithValue("@productId", productId);
            update.ExecuteNonQuery();
        }


        public List<Product> PopulateMenu()
        {
            List<Product> menu = new List<Product>();

            string sqlProducts = "SELECT * FROM buyproduct";
            MySqlCommand command = new MySqlCommand(sqlProducts, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int pId = Convert.ToInt32(reader["ProductID"]);
                string pName = Convert.ToString(reader["ProductName"]);
                string pCategory = Convert.ToString(reader["ProductCategory"]);
                decimal pPrice = Convert.ToDecimal(reader["Price"]);
                menu.Add(new Product(pId, pName, pCategory, pPrice));
            }
            reader.Close();

            return menu;
        }


    }
}
