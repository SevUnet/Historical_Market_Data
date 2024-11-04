using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMData
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //UIC value
            Random rnd = new Random((int)DateTime.Now.Ticks);
            uic_textbox.Text = rnd.Next(1, 1000000).ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void gen_button_Click(object sender, EventArgs e)
        {
            //UIC value
            Random rnd = new Random((int)DateTime.Now.Ticks);
            uic_textbox.Text = rnd.Next(1, 1000000).ToString();
            
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (ticker_textbox.Text == "" | name_textbox.Text == "" | currency_textbox.Text == "" | type_combobox.Text == "")
            {
                log_textbox.Text = log_textbox.Text + "\r\n Missing fields.. please check";
            }
            else
            {
                log_textbox.Text = "\r\n All good ! ";
            }
        }

        private void clear_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            log_textbox.Text = "";
        }
    }
}
