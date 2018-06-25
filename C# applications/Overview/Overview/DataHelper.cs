using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Overview
{
    class DataHelper
    {
        public MySqlConnection connection;
        

        public DataHelper()
        {
            String connectionInfo = "server = studmysql01.fhict.local;" + "database=dbi362350;"
            + "userid=dbi362350;" + "password=123123;";

            connection = new MySqlConnection(connectionInfo);
        }

        public Customer GetCustomerStatus(int id)
        {
            int status = 0;
            string sqlGetCustomer = "SELECT * FROM customer WHERE CustomerID = @id";
            MySqlCommand command = new MySqlCommand(sqlGetCustomer, connection);
            command.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    status = Convert.ToInt32(reader["EventStatus"]);
                }
                reader.Close();
            }
            else
            {
                reader.Close();
                throw new ThrowException("Visitor not found!");

            }
            

            Customer c = new Customer(id, status);
            return c;
        }


        public List<Customer> GetCustomerHistory(int id)
        {
            List<Customer> customerHistory = new List<Customer>();
            string sqlGetHistory = "SELECT * FROM customerhistory WHERE CustomerID = @customerId";
            MySqlCommand command = new MySqlCommand(sqlGetHistory, connection);
            command.Parameters.AddWithValue("@customerId", id);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DateTime timeChecked = Convert.ToDateTime(reader["EventCheckedTime"]);
                    int status = Convert.ToInt32(reader["EventStatus"]);
                    customerHistory.Add(new Customer(id, timeChecked, status));
                }
                reader.Close();
            }
            else
            {
                reader.Close();
                throw new ThrowException("Visitor not found!");

            }
            

            
            return customerHistory;
        }

        public int GetVisitorsPresent()
        {
            string sqlGetPresentVisitors = "SELECT COUNT(*) FROM customer WHERE EventStatus = 1";
            MySqlCommand command = new MySqlCommand(sqlGetPresentVisitors, connection);
            int present = Convert.ToInt32(command.ExecuteScalar());
            return present;
        }
        public int GetVisitorsRegistered()
        {
            string sqlGetAllVisitors = "SELECT COUNT(*) FROM customer";
            MySqlCommand command = new MySqlCommand(sqlGetAllVisitors, connection);
            int allVisitors = Convert.ToInt32(command.ExecuteScalar());
            return allVisitors;
        }

        public decimal GetTotalBalanceVisitors()
        {
            string sqlGetBalance = "SELECT Sum(Balance) FROM customer";
            MySqlCommand command = new MySqlCommand(sqlGetBalance, connection);
            decimal totalBalance = Convert.ToDecimal(command.ExecuteScalar());
            return totalBalance;
        }

        public decimal GetMoneySpent()
        {
            string sqlGetMoney = "SELECT Sum(Profit) FROM profitloan";
            MySqlCommand command = new MySqlCommand(sqlGetMoney, connection);
            decimal totalMoney = Convert.ToDecimal(command.ExecuteScalar());

            string sqlGetMoney1 = "SELECT Sum(Profit) FROM buystore";
            MySqlCommand command1 = new MySqlCommand(sqlGetMoney1, connection);
            decimal totalMoney1 = Convert.ToDecimal(command1.ExecuteScalar());

            return totalMoney + totalMoney1;
        }

        public decimal GetProfitPerStore(int shopId)
        {
            decimal profit = 0;
            string sqlGetProfit = "SELECT Profit FROM buystore WHERE StoreID = @id";
            MySqlCommand command = new MySqlCommand(sqlGetProfit, connection);
            command.Parameters.AddWithValue("@id", shopId);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    profit = Convert.ToDecimal(reader["Profit"]);
                }
                reader.Close();
            }
            else { reader.Close(); throw new ThrowException("Store not found!"); }
            
            return profit;
        }

        public int GetAmountProduct(int productId)
        {
            int amount = 0;
            string sqlGetAmount = "SELECT AmountSold FROM buyproduct WHERE ProductID = @id";
            MySqlCommand command = new MySqlCommand(sqlGetAmount, connection);
            command.Parameters.AddWithValue("@id", productId);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    amount = Convert.ToInt32(reader["AmountSold"]);
                }
                reader.Close();
            }
            else { reader.Close(); throw new ThrowException("Store not found!"); }
            
            return amount;
        }

        public List<string> GetBookedSpots()
        {
            List<string> bookedSpots = new List<string>();
            string sqlGetBookedSpots = "SELECT * FROM customer WHERE CampReservation=1";
            MySqlCommand command = new MySqlCommand(sqlGetBookedSpots, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string spotId = Convert.ToString(reader["SpotID"]);
                    bookedSpots.Add(spotId);
                }
                reader.Close();
            }
            else
            {
                reader.Close();
                throw new ThrowException("Camping spots not found!");

            }
            
            return bookedSpots;
        }

        public int GetFreeSpots()
        {
            string sqlGetFreeSpots = "SELECT COUNT(*) FROM customer WHERE CampReservation=1";
            MySqlCommand command = new MySqlCommand(sqlGetFreeSpots, connection);
            int takenSpots = Convert.ToInt32(command.ExecuteScalar());
            return 10 - takenSpots;
        }

        public List<LoanedProduct> GetLoanedProducts()
        {
            List<LoanedProduct> loanedProducts = new List<LoanedProduct>();
            string sqlGetProducts = "SELECT * FROM loanstore";
            MySqlCommand command = new MySqlCommand(sqlGetProducts, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string name = Convert.ToString(reader["ProductName"]);
                    int amount = Convert.ToInt32(reader["AmountBorrowed"]);
                    loanedProducts.Add(new LoanedProduct(name, amount));
                }
                reader.Close();
            }
            else
            {
                reader.Close();
                throw new ThrowException("No products found!");

            }
            


            return loanedProducts;
        }

        public decimal GetProfitPerStand(int standId)
        {
            decimal profit = 0;
            string sqlGetProfit = "SELECT Profit FROM profitloan WHERE LoanStoreID = @id";
            MySqlCommand command = new MySqlCommand(sqlGetProfit, connection);
            command.Parameters.AddWithValue("@id", standId);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    profit = Convert.ToDecimal(reader["Profit"]);
                }
                reader.Close();
            }
            else { reader.Close(); throw new ThrowException("Store not found!"); }
            
            return profit;
        }

    }
}
