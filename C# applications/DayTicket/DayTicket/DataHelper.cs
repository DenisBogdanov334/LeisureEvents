using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DayTicket
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

        public void InsertCustomerTable(Customer c, string eventAccount)
        {
            string queryInsert = "INSERT INTO customer(Email, FirstName, LastName, PhoneNr, EventAccID, CampReservation)" +
                " VALUES(@email, @fName, @lName, @phone, @eventAcc, 0)";
            MySqlCommand insert = new MySqlCommand(queryInsert, connection);
            insert.Parameters.AddWithValue("@email", c.Email);
            insert.Parameters.AddWithValue("@fName", c.FirstName);
            insert.Parameters.AddWithValue("@lName", c.LastName);
            insert.Parameters.AddWithValue("@phone", c.PhoneNr);
            insert.Parameters.AddWithValue("@eventAcc", eventAccount);
            insert.ExecuteNonQuery();
        }
        public int GetNewCustomerID()
        {
            string queryGetId = "SELECT LAST_INSERT_ID() FROM customer";
            MySqlCommand getId = new MySqlCommand(queryGetId, connection);
            int id = Convert.ToInt32(getId.ExecuteScalar());
            return id;
        }

        public void InsertCustomerRfidTable(string rfid)
        {
            int id = GetNewCustomerID();
            string queryInsert = "INSERT INTO customerrfid(CustomerID, RfidNr) VALUES(@id, @rfid)";
            MySqlCommand insert = new MySqlCommand(queryInsert, connection);
            insert.Parameters.AddWithValue("@id", id);
            insert.Parameters.AddWithValue("@rfid", rfid);
            insert.ExecuteNonQuery();
        }

        public Customer GetCustomerInfo()
        {
            Customer c = null;
            int id = GetNewCustomerID();
            string query = "SELECT * FROM customer WHERE CustomerID = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string firstName = Convert.ToString(reader["FirstName"]);
                    string lastName = Convert.ToString(reader["LastName"]);

                    c = new Customer(id, firstName, lastName);
                }

                reader.Close();
            }
            else
            {
                reader.Close();
                throw new Exception("Customer not found!");
            }
            return c;
        }

    }
}
