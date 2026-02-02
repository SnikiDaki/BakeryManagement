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
        public OrderInformation(string username, double total, List<GitHubPov.Account_Types.Customer.Product> produkti)
        {
            InitializeComponent();
            user = username;
            produkti2 = produkti;
            total2 = total;
            Username.Text = user;
        }

        public static class Db
        {
            public static string konekcija = "Server=metro.proxy.rlwy.net;Port=20149;Database=railway;Uid=root;Pwd=mvxRtenxTQfNKFjrBnYNlhViwjyupHiS;SSLMode=Required;Connection Timeout=30;";
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
            
        }
        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                payment = radioButton1.Text;

            }
            else if (radioButton2.Checked) { payment = radioButton2.Text; }
            else { payment = radioButton3.Text; }

        }
        public void button1_Click(object sender, EventArgs e)
        {
            foreach (GitHubPov.Account_Types.Customer.Product product in produkti2)
            {
                produkat += product.ProductName.ToString();
                quantity += product.Quantity.ToString();

            }





            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "INSERT INTO orders(userid, product, price, quantity, pickup, payment, info) VALUES (@userid, @product, @price, @quantity, @pickup, @payment, @info)";
                MySqlCommand cmd = new MySqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@userid", user);
                cmd.Parameters.AddWithValue("@product", produkat);
                cmd.Parameters.AddWithValue("@price", total2);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@pickup", delivery);
                cmd.Parameters.AddWithValue("@payment", payment);
                cmd.Parameters.AddWithValue("@info", richTextBox1.Text);
                int potvrda = cmd.ExecuteNonQuery();
                if (potvrda > 0)
                {
                    MessageBox.Show("Order Inserted!");
                }


            }
            catch (Exception ex) { MessageBox.Show($"Erorr: {ex} "); }
        }

    }
}
