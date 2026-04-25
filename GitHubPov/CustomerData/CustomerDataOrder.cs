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
using GitHubPov.Account_Types;

namespace GitHubPov.CustomerData
{
    public partial class CustomerDataOrder : Form
    {
        public string user2;
        public int Uid;
        public CustomerDataOrder(string username, int uid)
        {
            InitializeComponent();
            user2 = username;
            labeluser.Text = user2;
            Uid = uid;
        }

        public static class Db
        {
            public static string konekcija = "server=localhost;user=root;password=;database=bakery";
            //public static string konekcija = "Server=metro.proxy.rlwy.net;Port=20149;Database=railway;Uid=root;Pwd=mvxRtenxTQfNKFjrBnYNlhViwjyupHiS;SSLMode=Required;Connection Timeout=30;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();

            try
            {
                string update = "UPDATE users SET firstname=@firstname, lastname=@lastname, email=@email, telefon=@telefon, adresa=@adresa, hnum=@hnum, city=@city WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(update, conn);
                cmd.Parameters.AddWithValue("username", user2);
                cmd.Parameters.AddWithValue("id", Uid);
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

        private void CustomerDataOrder_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "SELECT * FROM users WHERE username=@username and id=@id";
                MySqlCommand cmd = new MySqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@username", user2);
                cmd.Parameters.AddWithValue("@id", Uid);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = Convert.ToString(dr["firstname"]);
                    textBox2.Text = Convert.ToString(dr["lastname"]);
                    textBox3.Text = Convert.ToString(dr["email"]);
                    maskedTextBox1.Text = Convert.ToString(dr["telefon"]);
                    textBox4.Text = Convert.ToString(dr["adresa"]);
                    textBox5.Text = Convert.ToString(dr["hnum"]);
                    textBox6.Text = Convert.ToString(dr["city"]);
                }
                dr.Close();

                string orderselekt = "SELECT * FROM orders WHERE userid=@id";
                MySqlCommand cmd2 = new MySqlCommand(orderselekt, conn);

                cmd2.Parameters.AddWithValue("@id", Uid);
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    dataGridView1.Rows.Add(dr2["product"].ToString(), dr2["price"].ToString(), dr2["quantity"].ToString(), dr2["pickup"].ToString(), dr2["payment"].ToString(), dr2["status"].ToString(), dr2["date"].ToString());
                }
                dr2.Close();


            }
            catch (Exception ex) { MessageBox.Show($"Erorr: {ex} "); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer(user2, Uid);
            customer.Show();
        }

        private void labeluser_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DateTime dt = dateTimePicker1.Value;
            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {

                string orderselekt = "SELECT * FROM orders WHERE userid=@id and date=@date";
                MySqlCommand cmd2 = new MySqlCommand(orderselekt, conn);

                cmd2.Parameters.AddWithValue("@id", Uid);
                cmd2.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));

                MySqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    dataGridView1.Rows.Add(dr2["product"].ToString(), dr2["price"].ToString(), dr2["quantity"].ToString(), dr2["pickup"].ToString(), dr2["payment"].ToString(), dr2["status"].ToString(), dr2["date"].ToString());
                }



            }
            catch (Exception ex) { MessageBox.Show($"Erorr: {ex} "); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerDataOrder_Load(sender, e);
        }
    }
}
