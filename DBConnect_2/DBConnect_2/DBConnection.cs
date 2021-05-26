using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DBConnect
{
    class DBConnection
    {
        //server name
        //database
        //user name
        //password
        MySqlConnection connection = null;
        string connectionstring;

        public MySqlConnection Connection { get => connection; }

        public DBConnection(string servername, string database, string username, string password)
        {
            this.connectionstring = string.Format($"SERVER= {servername}; DATABASE={database}; UID={username}; PASSWORD={password}");
            
        }

        public bool Connect()
            {
            bool succeeded = true;
            try
            {
                this.connection = new MySqlConnection(connectionstring);
                this.connection.Open();
            }
            catch(MySqlException exp)
            {
                succeeded = false;
                switch(exp.Number)
                { 
                case 0:
                        MessageBox.Show("Authentication error  - please check login credentials");
                        break;
                case 1045:
                        MessageBox.Show("Cannot connect to server");
                        break;
                default:
                        MessageBox.Show("Exception found " +exp.ErrorCode);
                        break;
                }
            }
            
            return succeeded;
            }

        public bool Close()
        {
            bool succeeded = true;

            try
            {
                this.connection.Close();
            }
            catch(MySqlException exp)
            {
                succeeded = false;
                MessageBox.Show("Exception found "+exp.Message);
            }
            return succeeded;
        }
    }
}
