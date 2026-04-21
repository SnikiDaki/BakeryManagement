using GitHubPov.Account_Types;
using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GitHubPov.CustomerData
{
    public partial class OrderInformation : Form
    {

        public string user;
        public List<GitHubPov.Account_Types.Customer.Product> produkti2;
        public double total2;
        public int uid;
        public int potvrda;
        public double cena;
        public string proveratext;
        public OrderInformation(string username, double total, List<GitHubPov.Account_Types.Customer.Product> products, int userid, double price)
        {
            InitializeComponent();
            user = username;
            produkti2 = products;
            total2 = total;
            Username.Text = user;
            uid = userid;
            cena = price;
            radioButton1.Checked = true;
            radioButton6.Checked = true;

        }

        public static class Db
        {
            public static string konekcija = "server=localhost;user=root;password=;database=bakery";
            // public static string konekcija = "Server=metro.proxy.rlwy.net;Port=20149;Database=railway;Uid=root;Pwd=mvxRtenxTQfNKFjrBnYNlhViwjyupHiS;SSLMode=Required;Connection Timeout=30;";
        }
        private void OrderInformation_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "SELECT * FROM users WHERE username=@username";
                MySqlCommand cmd = new MySqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@username", user);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = Convert.ToString(dr["firstname"]);
                    textBox2.Text = Convert.ToString(dr["lastname"]);
                    textBox3.Text = Convert.ToString(dr["email"]);
                    maskedTextBox1.Text = Convert.ToString(dr["telefon"]);
                    textBox4.Text = Convert.ToString(dr["adresa"]);
                    textBox5.Text = Convert.ToString(dr["hnum"]);
                    textBox6.Text = Convert.ToString(dr["city"]);


                }
            }
            catch (Exception ex) { MessageBox.Show($"Erorr: {ex} "); }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }




        string produkat;
        string quantity;
        string delivery;
        string payment;
        public void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

            delivery = radioButton6.Text;



        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            delivery = radioButton7.Text;
        }
        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            payment = radioButton1.Text;
            pictureBox1.Visible = false;


            //if (radioButton1.Checked == false)
            //{
            //    label12.Visible = false;
            //    label13.Visible = false;
            //    label14.Visible = false;
            //    maskedTextBox2.Visible = false;
            //    maskedTextBox3.Visible = false;
            //    maskedTextBox4.Visible = false;
            //}
            //else
            //{
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox3.Visible = true;
                maskedTextBox4.Visible = true;

            //}

        }
        public void button1_Click(object sender, EventArgs e)
        {
            proveratext = "";

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || maskedTextBox1.Text =="") {

                proveratext = "prazno";
                
            }

                if (radioButton1.Checked) {

                    if (maskedTextBox2.Text == "" || maskedTextBox3.Text == "" || maskedTextBox4.Text == "")
                    {
                    proveratext = "prazno";
                        
                    }
                
                }

            
            
            
            if(proveratext != "prazno")
            {
            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
            foreach (GitHubPov.Account_Types.Customer.Product product in produkti2)
            {
                produkat = product.ProductName.ToString();
                quantity = product.Quantity.ToString();

                string select = "INSERT INTO orders(userid, product, price, quantity, pickup, payment, status, chefstatus, info, date) VALUES (@userid, @product, @price, @quantity, @pickup, @payment, 'Pending', 'Not Completed', @info, @date)";
                MySqlCommand cmd = new MySqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@product", produkat);
                cmd.Parameters.AddWithValue("@price", cena);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@pickup", delivery);
                cmd.Parameters.AddWithValue("@payment", payment);
                cmd.Parameters.AddWithValue("@info", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Today);


                    potvrda = cmd.ExecuteNonQuery();
                    long orderid = cmd.LastInsertedId;

                    for (int i = 0; i < Convert.ToInt32(quantity); i++) { 
                    
                    string insert = "insert into tasks(cakename,orderid, statustask) values(@cakename, @orderid ,'Not Completed')";
                    MySqlCommand cmd2 = new MySqlCommand(insert, conn);
                    cmd2.Parameters.AddWithValue("@cakename", produkat);
                    cmd2.Parameters.AddWithValue("@orderid", orderid);

                    cmd2.ExecuteNonQuery();
                    
                    }

            }
                if (potvrda > 0)
                {
                    MessageBox.Show("Order Completed!");
                    Customer customer = new Customer(user,uid);
                    customer.FormClosed += (s, args) => this.Close();
                    this.Hide();
                    customer.Show();
                }


            }
            catch (Exception ex) { MessageBox.Show($"Erorr: {ex} "); }


            }
            else
            {
                MessageBox.Show("Please fill out required fields!", "Order");
            }
            
            
           



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            payment = radioButton2.Text;
            pictureBox1.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            maskedTextBox2.Visible = false;
            maskedTextBox3.Visible = false;
            maskedTextBox4.Visible = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            payment = radioButton3.Text;
            pictureBox1.Visible = true;
            label13.Visible = false;
            label14.Visible = false;
            maskedTextBox2.Visible = false;
            maskedTextBox3.Visible = false;
            maskedTextBox4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();

            try
            {
                string update = "UPDATE users SET firstname=@firstname, lastname=@lastname, email=@email, telefon=@telefon, adresa=@adresa, hnum=@hnum, city=@city WHERE username=@username";
                MySqlCommand cmd = new MySqlCommand(update, conn);
                cmd.Parameters.AddWithValue("username", user);
                cmd.Parameters.AddWithValue("@firstname", textBox1.Text);
                cmd.Parameters.AddWithValue("@lastname", textBox2.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@telefon", Convert.ToString(maskedTextBox1.Text));
                cmd.Parameters.AddWithValue("@adresa", textBox4.Text);
                cmd.Parameters.AddWithValue("@hnum", textBox5.Text);
                cmd.Parameters.AddWithValue("@city", textBox6.Text);
                int updejt = Convert.ToInt32(cmd.ExecuteNonQuery());

                if (updejt > 0)
                {
                    MessageBox.Show($"Your information has been successfully updated!");
                }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex} "); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(user,uid);
            customer.FormClosed += (s, args) => this.Close();
            this.Hide();
            customer.Show();
        }
    }
}
