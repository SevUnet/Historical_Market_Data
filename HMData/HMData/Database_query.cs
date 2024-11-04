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
        public static string nickname;

        public static void ConnectionDB()
        {
            host = "localhost";
            database = "hmdata";
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
        
        //Account settings
        public static void accountsparam()
        {
            ConnectionDB();

            try
            {
                MySqlCommand commandsql = new MySqlCommand("SELECT * FROM accounts WHERE Login = '" + Auth.username + "' ", con);
                MySqlDataReader parametres = commandsql.ExecuteReader();

                while (parametres.Read())
                {
                    nickname = parametres["Nickname"].ToString();
                }
            }
            catch (Exception IO)
            {

            }

            con.Close();
        }

    }
}
