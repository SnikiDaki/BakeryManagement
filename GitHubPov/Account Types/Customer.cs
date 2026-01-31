using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubPov.CustomerData;

namespace GitHubPov.Account_Types
{
    public partial class Customer : Form
    {
        public string User1;
        public Customer(string username)
        {
            InitializeComponent();
            User1 = username;
            linkLabel1.Text = User1;
        }

        public static class Db
        {
            public static string konekcija = "Server=metro.proxy.rlwy.net;Port=20149;Database=railway;Uid=root;Pwd=mvxRtenxTQfNKFjrBnYNlhViwjyupHiS;SSLMode=Required;Connection Timeout=30;";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerDataOrder cdr = new CustomerDataOrder(User1);
            this.Hide();
            cdr.Show();
        }
    }
}
