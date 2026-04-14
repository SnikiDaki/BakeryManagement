using GitHubPov.CustomerData;
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
using static GitHubPov.Account_Types.Customer;


namespace GitHubPov.Account_Types
{
    public partial class Customer : Form
    {
        public string User1;
        public int total;
        public int Userid;
        public double price;

        public Customer(string username, int userid)
        {
            InitializeComponent();
            User1 = username;
            Userid = userid;
            linkLabel1.Text = User1;
            numericUpDown1.Maximum = 50;
            numericUpDown1.Minimum = 1;
            numericUpDown2.Maximum = 50;
            numericUpDown2.Minimum = 1;
            numericUpDown3.Maximum = 50;
            numericUpDown3.Minimum = 1;
            numericUpDown4.Maximum = 50;
            numericUpDown4.Minimum = 1;
            numericUpDown5.Maximum = 50;
            numericUpDown5.Minimum = 1;
            numericUpDown6.Maximum = 50;
            numericUpDown6.Minimum = 1;

        }
        public class Product
        {
            public string? ProductName { get; set; }
            public double Price { get; set; }
            public int? Quantity { get; set; }

        }
        List<Product> products = new List<Product>();



        public static class Db
        {
            public static string konekcija = "server=localhost;user=root;password=;database=bakery";
            // public static string konekcija = "Server=metro.proxy.rlwy.net;Port=20149;Database=railway;Uid=root;Pwd=mvxRtenxTQfNKFjrBnYNlhViwjyupHiS;SSLMode=Required;Connection Timeout=30;";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerDataOrder cdr = new CustomerDataOrder(User1,Userid);
            cdr.FormClosed += (s, args) => this.Close();
            this.Hide();
            cdr.Show();
        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            //  Cart cart = new Cart(User1, products);
            //  this.Hide();
            // cart.Show();
        }


        public void button1_Click_1(object sender, EventArgs e)
        {
            
            products.Add(new Product { ProductName = "Raspberry Cake ", Price = 25, Quantity = (int)numericUpDown4.Value });
            korpa();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            products.Add(new Product { ProductName = "Chocolate Plazma Cake ", Price = 25, Quantity = (int)numericUpDown5.Value });
            korpa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            products.Add(new Product { ProductName = "Sacher Cake ", Price = 25, Quantity = (int)numericUpDown6.Value });
            korpa();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            products.Add(new Product { ProductName = "Honey Cake ", Price = 25, Quantity = (int)numericUpDown3.Value });
            korpa();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            products.Add(new Product { ProductName = "Black Forest Cake ", Price = 25, Quantity = (int)numericUpDown2.Value });
            korpa();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            products.Add(new Product { ProductName = "Red Velvet Cake ", Price = 25, Quantity = (int)numericUpDown1.Value });
            korpa();
        }

        public void korpa()
        {
            dataGridView1.Rows.Clear();
            listView1.Items.Clear();
            total = 0;

            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(product.ProductName);
                item.SubItems.Add(product.Price.ToString());
                item.SubItems.Add(product.Quantity.ToString());
                price = product.Price;
                total += (int)(product.Price * product.Quantity);

                listView1.Items.Add(item);

                dataGridView1.Rows.Add(product.ProductName, product.Price.ToString(), product.Quantity.ToString());
            }
            label16.Text = $"Total : {total}$";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OrderInformation oi = new OrderInformation(User1, total, products,Userid, price);
            this.Hide();
            oi.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            total = 0;
            listView1.Items.Clear();
            products.Clear();
            dataGridView1.Rows.Clear();
            label16.Text = $"Total : {total}$";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductName"].Value);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }


            int index = listView1.SelectedIndices[0];

            if (index >= 0 && index < products.Count)
            {
                products.RemoveAt(index);
                listView1.Items.RemoveAt(index);



                korpa();
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Raspberry Cake\n Ingredients: Raspberries, Chocolate", "More Info");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chocolate Plazma Cake\n Ingredients: Plazma biscuits, Chocolate Pudding, Vanilla Pudding, Whip Cream", "More Info");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sacher Cake\nIngredients: Apricot marmalade, Chocolate dough", "More Info");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Honey Cake\nIngredients: Honey, Almonds, Orange", "More Info");

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Black Forest Cake\nIngredients: Cocoa, Forest Berries", "More Info");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Red Velvet Cake\nIngredients: Cocoa, Cream Cheese", "More Info");
        }
    }
}
