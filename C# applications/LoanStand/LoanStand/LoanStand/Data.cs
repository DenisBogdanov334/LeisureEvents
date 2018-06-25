using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LoanStand
{
    class Data
    {

        Customer customer;
        public MySqlConnection connection;
        int customerId = 0;
        decimal customerBalance = 0;
        public Data()
        {
            string connectioninfo = "server = studmysql01.fhict.local;" + "database=dbi362350;"
            + "userid=dbi362350;" + "password=123123;";
            connection = new MySqlConnection(connectioninfo);
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
                throw new CustomerException("Rfid not found!");
            }
            return custId;
        }

        public Customer Customer(string rfid)
        {
            string sql = "SELECT * FROM customer WHERE CustomerID = @id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", GetCustomerID(rfid));
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    customerId = Convert.ToInt32(reader["CustomerID"]);
                    
                }
            }

            else
            {
                throw new CustomerException("Customer not found!");

            }
            reader.Close();

            
            string sqlGetBalance = "SELECT * FROM customer WHERE CustomerID = @customerId";
            MySqlCommand command1 = new MySqlCommand(sqlGetBalance, connection);
            command1.Parameters.AddWithValue("@customerId", customerId);
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                customerBalance = Convert.ToDecimal(reader1["Balance"]);
            }
            reader1.Close();

            customer = new Customer(customerId, customerBalance);
            return customer;
        }


        public List<int> GetStores()
        {
            List<int> loanstands = new List<int>();
            string sqlloan = "SELECT * FROM profitloan";
            MySqlCommand command = new MySqlCommand(sqlloan, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int loanstoreID = Convert.ToInt32(reader["LoanStoreID"]);
                loanstands.Add(loanstoreID);
            }
            reader.Close();
            

            return loanstands;
        }

        public List<Product> Products()
        {
            List<Product> products = new List<Product>();
            
            string sqlProducts = "SELECT * FROM loanstore";
            MySqlCommand command = new MySqlCommand(sqlProducts, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int Id = Convert.ToInt32(reader["LoanProductID"]);
                string Name = Convert.ToString(reader["ProductName"]);
                decimal Price = Convert.ToDecimal(reader["Price"]);
                products.Add(new Product(Id, Name, Price));
            }
            reader.Close();

            
            return products;
        }

        public void Stand(int standid, decimal profit)
        {
            MySqlCommand update;
            string updatestand = "UPDATE profitloan SET Profit = Profit + @billTotal WHERE LoanStoreID = @standID";
            update = new MySqlCommand(updatestand, connection);
            update.Parameters.AddWithValue("@billTotal", profit);
            update.Parameters.AddWithValue("@standID", standid);
            update.ExecuteNonQuery();
        }
        public void EventAccount(int customerid, decimal newbalance)
        {
            MySqlCommand update;
            string Changebalance = "UPDATE customer SET Balance = @newbalance WHERE CustomerID = @customerId";
            update = new MySqlCommand(Changebalance, connection);
            update.Parameters.AddWithValue("@newbalance", newbalance);
            update.Parameters.AddWithValue("@customerId", customerid);
            update.ExecuteNonQuery();
        }
        public void Product(int productid, int amount)
        {
            MySqlCommand update;
            string updateproduct = "UPDATE loanstore SET AmountBorrowed = AmountBorrowed + @amount WHERE LoanProductID = @productid";
            update = new MySqlCommand(updateproduct, connection);
            update.Parameters.AddWithValue("@amount", amount);
            update.Parameters.AddWithValue("@productid", productid);
            update.ExecuteNonQuery();
        }


        public void UpdateCustomerLoanedTrue(int custID)
        {
            MySqlCommand update;
            string queryChangeStatusLoaned = "";
            queryChangeStatusLoaned = "UPDATE customer SET LoanedProduct = 1 WHERE CustomerID =@id";
            update = new MySqlCommand(queryChangeStatusLoaned, connection);
            update.Parameters.AddWithValue("@id",custID);
            update.ExecuteNonQuery();
        }

        public void ReturnProduct(int productid, int amount)
        {
            MySqlCommand update;
            string updateproduct = "UPDATE loanstore SET AmountBorrowed = AmountBorrowed - @amount WHERE LoanProductID = @productid";
            update = new MySqlCommand(updateproduct, connection);
            update.Parameters.AddWithValue("@amount", amount);
            update.Parameters.AddWithValue("@productid", productid);
            update.ExecuteNonQuery();
        }
        public void UpdateCustomerLoanedFalse(int custID)
        {
            MySqlCommand update;
            string queryChangeStatusLoaned = "";
            queryChangeStatusLoaned = "UPDATE customer SET LoanedProduct = 0 WHERE CustomerID =@id";
            update = new MySqlCommand(queryChangeStatusLoaned, connection);
            update.Parameters.AddWithValue("@id", custID);
            update.ExecuteNonQuery();
        }
    }
}
