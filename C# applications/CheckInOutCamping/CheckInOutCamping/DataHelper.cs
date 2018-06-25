using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CheckInOutCamping
{
    class DataHelper
    {
        public MySqlConnection connection;
        Customer tempCustomer = null;
        string firstName = "", lastName = "";
        int campStatus = 0;
        string spotId;
        bool reservation = false;
        
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
            else { reader.Close(); throw new ThrowException("Rfid not found!"); }
            return custId;
        }

        public Customer GetCustomer(string rfid)
        {
            int customerId = GetCustomerID(rfid);
            string sqlGetCustomer = "SELECT * FROM customer WHERE CustomerID=@id";

            MySqlCommand command = new MySqlCommand(sqlGetCustomer, connection);
            command.Parameters.AddWithValue("@id", customerId);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    firstName = Convert.ToString(reader["FirstName"]);
                    lastName = Convert.ToString(reader["LastName"]);
                    campStatus = Convert.ToInt32(reader["CampStatus"]);
                    int campReservation = Convert.ToInt32(reader["CampReservation"]);
                    spotId = Convert.ToString(reader["SpotID"]);
                    if (campReservation == 1)
                    {
                        reservation = true;
                    }
                    else if (campReservation == 0)
                    {
                        reader.Close();
                        reservation = false;
                        throw new ThrowException("No reservation found!");
                    }
                }
                reader.Close();
            }
            else { reader.Close(); throw new ThrowException("Visitor not found"); }

            tempCustomer = new Customer(customerId, firstName, lastName, campStatus, spotId, reservation);
            return tempCustomer;
        }


        public void UpdateCustomertable()
        {
            MySqlCommand update;
            string queryChangeStatusCamp = "";

            if (tempCustomer.CheckedStatusCamp == 0)
            {
                queryChangeStatusCamp = "UPDATE customer SET CampStatus = 1 WHERE CustomerID =@id";
            }

            else if (tempCustomer.CheckedStatusCamp == 1)
            {
                queryChangeStatusCamp = "UPDATE customer SET CampStatus = 0 WHERE CustomerID =@id";
            }

            update = new MySqlCommand(queryChangeStatusCamp, connection);
            update.Parameters.AddWithValue("@id", tempCustomer.Id);
            update.ExecuteNonQuery();

        }

    }
}

