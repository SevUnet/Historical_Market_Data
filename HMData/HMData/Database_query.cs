using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace HMData
{
    class Database_query
    {
        public static string host;
        public static string database;
        public static string user;
        public static string password;
        public static MySqlConnection con;

        public static void ConnectionDB()
        {
            host = "localhost";
            database = "loto";
            user = "root";
            password = "";

            string constr = "Server=" + host + ";DATABASE=" + database + ";User ID=" + user + ";Password=" + password + ";Pooling=true;Charset=utf8;SslMode=none;";

            try
            {       
                con = new MySqlConnection(constr);
                con.Open();
            }
            catch (IOException Ex)
            {
                MessageBox.Show("Connection failed     " + Ex.ToString());
            }
        }

    }
}
