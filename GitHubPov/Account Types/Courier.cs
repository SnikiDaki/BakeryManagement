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
    public partial class Courier : Form
    {
        public string userime;
        public int Userid;
        public Courier(string username, int userid)
        {
            InitializeComponent();
            userime = username;
            Userid = userid;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login eo = new Login();
            eo.FormClosed += (s, args) => this.Close();
            this.Hide();
            eo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourierDeliveries coi = new CourierDeliveries(userime, Userid);
            coi.FormClosed += (s, args) => this.Close();
            this.Hide();
            coi.Show();
        }
    }
}
