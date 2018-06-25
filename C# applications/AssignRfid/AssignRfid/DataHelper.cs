using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AssignRfid
{
    class DataHelper
    {
        public MySqlConnection connection;
        Customer tempCustomer;
        int customerId = 0;
        string firstName, lastName, address;

        public DataHelper()
        {
            String connectionInfo = "server = studmysql01.fhict.local; " +
            "database=dbi362350;" +
            "user id=dbi362350;" +
            "password=123123;";
            connection = new MySqlConnection(connectionInfo);

        }

        public Customer GetCustomer()
        {
            string sqlGetCustomer = "SELECT * FROM customer c WHERE NOT EXISTS (SELECT * FROM customerrfid cr WHERE c.CustomerID = cr.CustomerID)";
            MySqlCommand command = new MySqlCommand(sqlGetCustomer, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    customerId = Convert.ToInt32(reader["CustomerID"]);
                    firstName = Convert.ToString(reader["FirstName"]);
                    lastName = Convert.ToString(reader["LastName"]);
                    address = Convert.ToString(reader["Address"]);
                    tempCustomer = new Customer(customerId, firstName, lastName, address);
                }
                reader.Close();
            }
            else
            {
                reader.Close();
                throw new ThrowException("Visitors without RFID are not found!");
            }
            
            return tempCustomer;
        }

        public void InsertCustomerRfidTable(int id, string rfid)
        {
            
            if (tempCustomer != null)
            {
                string queryInsert = "INSERT INTO customerrfid(CustomerID, RfidNr) VALUES(@id, @rfid)";
                MySqlCommand insert = new MySqlCommand(queryInsert, connection);
                insert.Parameters.AddWithValue("@id", id);
                insert.Parameters.AddWithValue("@rfid", rfid);
                insert.ExecuteNonQuery();
            }

            else
            {
                throw new ThrowException("Customer not added to customerrfid table!");
            }
        }

        
    }
}
