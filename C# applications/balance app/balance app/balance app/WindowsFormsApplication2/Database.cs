using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    class Database
    {
        public MySqlConnection connection;
        int account;
       //decimal balance;
        string x;
        public Database()
        {
            String connectionInfo = "server=studmysql01.fhict.local;" +
                                      "database=dbi362350;" +
                                      "user id=dbi362350;" +
                                      "password=123123;" +
                                      "connect timeout=30;";
            

            connection = new MySqlConnection(connectionInfo);
        }
        public List<string> LogFile()
        {
            
            
            List<string> logfilee = new List<string>();
            {
                
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\Users\\Kalo\\Desktop";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader r = new StreamReader(openFileDialog1.OpenFile()))
                        {
                            
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                logfilee.Add(line);
                                if (logfilee.Count > 4)
                                {
                                   
                                    string[] money = line.Split(' ');
                                    account = Convert.ToInt32(money[0]);
                                    x = money[1];
                                    try
                                    {
                                        connection.Open();
                                        string Query = "UPDATE customer SET Balance = @balance WHERE EventAccID = @account";
                                        MySqlCommand comm = new MySqlCommand(Query, connection);
                                        comm.Parameters.AddWithValue("@balance", x);
                                        comm.Parameters.AddWithValue("@account", account);
                                        comm.ExecuteNonQuery();

                                        MySqlDataReader reader = comm.ExecuteReader();
                                        

                                    }
                                    catch
                                    {
                                        MessageBox.Show("Error by connecting to database");
                                    }
                                    finally
                                    {
                                        
                                        connection.Close();
                                        
                                    }
                                }
                           
                            }
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }


            MessageBox.Show("Log file sent");

            return logfilee;
        }

    }
}
