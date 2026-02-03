using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubPov.CustomerData;
using GitHubPov.Account_Types;


namespace GitHubPov.CustomerData
{
    public partial class Cart : Form
    {
        public string user;
        public List<GitHubPov.Account_Types.Customer.Product> produkti;
        public Cart(string username, List<GitHubPov.Account_Types.Customer.Product> products)
        {
            InitializeComponent();
            user = username;
            produkti = products;

        }

        double total = 0;
        private void Cart_Load(object sender, EventArgs e)
        {
            foreach (GitHubPov.Account_Types.Customer.Product product in produkti)
            {
                ListViewItem item = new ListViewItem(product.ProductName);
                item.SubItems.Add(product.Price.ToString());
                item.SubItems.Add(product.Quantity.ToString());

                total += product.Price;

                listView1.Items.Add(item);
                label1.Text = $"Total : {total}$";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderInformation oi = new OrderInformation(user, total, produkti);
            this.Hide();
            oi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Customer customer = new Customer(user);
            this.Hide();
            customer.Show();
        }
    }
}
