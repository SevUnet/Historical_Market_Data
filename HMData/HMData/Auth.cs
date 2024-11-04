using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace HMData
{
    public partial class Auth : Form
    {
        public static string username;
        public static string nickname;
        public Auth()
        {
            InitializeComponent();

            //DB
            Database_query.ConnectionDB();
            label3.Text = "Server : " + Database_query.con.State.ToString();
            label3.ForeColor = Color.Green;
            login.Text = "admin";
            password.Text = "admin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database_query.ConnectionDB();
            
            string pass = null;
            string access = null;

            try
            {
                MySqlCommand commandsql = new MySqlCommand("SELECT * FROM accounts WHERE Login = '" + login.Text + "'", Database_query.con);
                MySqlDataReader auth = commandsql.ExecuteReader();

                while (auth.Read())
                {
                    pass = auth["Password"].ToString();
                    access = auth["Access"].ToString();
                    nickname = auth["Nickname"].ToString();

                    if (pass == password.Text & access == "1")
                    {
                        username = login.Text;
                        Database_query.accountsparam();
                        //MessageBox.Show("User : " + nickname + " logged - " + " Nickname : " + Database_query.nickname);
                        Auth.ActiveForm.Hide();
                        Main f = new Main();
                        f.Show();
                        //Auth.ActiveForm.Hide();
                    }
                    else if (access != "1")
                    {
                        MessageBox.Show("Account hasn't been activated, please contact the administrator");
                    }
                    else if (pass != password.Text)
                    {
                        MessageBox.Show("Password wrong");
                    }
                    else if(pass == "" || pass == null)
                    {
                        MessageBox.Show("Login wrong");
                    }
                    else
                    {
                        MessageBox.Show("Login or password wrong");
                    }
                }
            }
            catch (Exception ter)
            {
                MessageBox.Show("Exception: " + ter.Message);
            }
        }
    }
}
