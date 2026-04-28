using GitHubPov.Account_Types;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GitHubPov.Account_Type_s
{
    public partial class Cashier : Form
    {
        public string userime;
        public int Userid;
        public Cashier(string username, int userid)
        {
            InitializeComponent();
            userime = username;
            Userid = userid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(userime, Userid);
            customer.FormClosed += (s, args) => this.Close();
            this.Hide();
            customer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourierDeliveries cd = new CourierDeliveries(userime, Userid);
            cd.FormClosed += (s, args) => this.Close();
            this.Hide();
            cd.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login eo = new Login();
            eo.FormClosed += (s, args) => this.Close();
            this.Hide();
            eo.Show();
        }
    }
}
