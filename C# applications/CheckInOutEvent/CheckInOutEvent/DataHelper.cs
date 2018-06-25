using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CheckInOutEvent
{
    class DataHelper
    {
        public MySqlConnection connection;
        string dateTime;
        Customer tempCustomer;

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

        public Customer GetCustomer(string rfidNr)
        {
            int customerId = GetCustomerID(rfidNr);

            string sqlGetCustomer = "SELECT * FROM customer WHERE CustomerID=@id";
            MySqlCommand command = new MySqlCommand(sqlGetCustomer, connection);
            command.Parameters.AddWithValue("@id", customerId);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string firstName = Convert.ToString(reader["FirstName"]);
                    string lastName = Convert.ToString(reader["LastName"]);
                    int eventStatus = Convert.ToInt32(reader["EventStatus"]);
                    int loanStatus = Convert.ToInt32(reader["LoanedProduct"]);

                    tempCustomer = new Customer(rfidNr, customerId, firstName, lastName, eventStatus, loanStatus);
                }
                reader.Close();

            }
            else
            {
                reader.Close();
                throw new ThrowException("Visitor not found!");
            }

            return tempCustomer;
        }

        public void UpdateCustomertable()
        {
            MySqlCommand update;
            string queryChangeStatusEvent = "";
            if (tempCustomer.CheckedStatusEvent == 0)
            {
                queryChangeStatusEvent = "UPDATE customer SET EventStatus = 1 WHERE CustomerID =@id";
            }
            else if (tempCustomer.CheckedStatusEvent == 1)
            {
                queryChangeStatusEvent = "UPDATE customer SET EventStatus = 0 WHERE CustomerID =@id";
            }

            update = new MySqlCommand(queryChangeStatusEvent, connection);
            update.Parameters.AddWithValue("@id", tempCustomer.Id);
            update.ExecuteNonQuery();
        }

        public void InsertCustomerHistory()
        {
            MySqlCommand insert;
            string queryInsertHistory = "";
            if (tempCustomer.CheckedStatusEvent == 0)
            {
                dateTime = DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss");
                queryInsertHistory = "INSERT INTO customerhistory(CustomerID, EventCheckedTime, EventStatus)" +
                                     " VALUES ('" + tempCustomer.Id + "', '" + dateTime + "', '1')";
            }

            else if (tempCustomer.CheckedStatusEvent == 1)
            {
                dateTime = DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss");
                queryInsertHistory = "INSERT INTO customerhistory(CustomerID, EventCheckedTime, EventStatus)" +
                                     " VALUES ('" + tempCustomer.Id + "', '" + dateTime + "', '0')";
            }

            insert = new MySqlCommand(queryInsertHistory, connection);
            insert.ExecuteNonQuery();
        }
    }
}
