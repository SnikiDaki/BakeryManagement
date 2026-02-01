using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubPov.CustomerData
{
    public partial class Cart : Form
    {
        public string user;
        public Cart(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }
    }
}
