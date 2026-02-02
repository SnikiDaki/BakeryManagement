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
        List<Product> products = new List<Product>();
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

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(User1, products);
            this.Hide();
            cart.Show();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            products.Add(new Product { ProductName = "Torta 1", Price = 25, Quantity = 1 });
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        public class Product
        {
            public string? ProductName { get; set; }
            public float Price { get; set; }
            public int? Quantity { get; set; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            products.Add(new Product { ProductName = "Torta 2", Price = 25, Quantity = 1 });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            products.Add(new Product { ProductName = "Torta 3", Price = 25, Quantity = 1 });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            products.Add(new Product { ProductName = "Torta 4", Price = 25, Quantity = 1 });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            products.Add(new Product { ProductName = "Torta 5", Price = 25, Quantity = 1 });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            products.Add(new Product { ProductName = "Torta 6", Price = 25, Quantity = 1 });
        }
    }
}
