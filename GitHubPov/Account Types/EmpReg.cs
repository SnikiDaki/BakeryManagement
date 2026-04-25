using GitHubPov.Account_Type_s;
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

namespace GitHubPov.Account_Types
{
    public partial class EmpReg : Form
    {
        public string userime;
        public int Userid;
        public int x = 0;
        public EmpReg(string username, int userid)
        {
            InitializeComponent();
            userime = username;
            Userid = userid;
        }

        public static class Db
        {
            public static string konekcija = "server=localhost;user=root;password=;database=bakery";
            //public static string konekcija = "Server=metro.proxy.rlwy.net;Port=20149;Database=railway;Uid=root;Pwd=mvxRtenxTQfNKFjrBnYNlhViwjyupHiS;SSLMode=Required;Connection Timeout=30;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            string username = textBox3.Text;
            string email = textBox4.Text;
            string password = textBox5.Text;
            string passcheck = textBox6.Text;
            string role = comboBox1.Text;
            string adresa = textBox9.Text;
            string telefon = maskedTextBox1.Text;

            int hnum = Convert.ToInt32(textBox8.Text);

            string city = textBox7.Text;



            if (firstname == "" || lastname == "" || username == "" || email == "" || password == "" || passcheck == "" || role == "" || adresa == "" || telefon == "" || hnum == null || city == "")
            {
                MessageBox.Show($"Please fill out the required fields!", "Register");
            }
            else
            {


                MySqlConnection conn = new MySqlConnection(Db.konekcija);

                conn.Open();
                try
                {
                    string insert = "INSERT INTO users (firstname, lastname, username, email, password, role, telefon, adresa, hnum, city) VALUES (@firstname, @lastname, @username, @email, @password, @role, @telefon, @adresa, @hnum, @city)";
                    MySqlCommand cmd = new MySqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@telefon", telefon);
                    cmd.Parameters.AddWithValue("@adresa", adresa);
                    cmd.Parameters.AddWithValue("@hnum", hnum);
                    cmd.Parameters.AddWithValue("@city", city);




                    if (password == passcheck)
                    {
                        int b = Convert.ToInt32(cmd.ExecuteNonQuery());
                        if (b == 1)
                        {
                            MessageBox.Show($"Registration successful!", "Register");
                             textBox1.Text = "";
                             textBox2.Text = "";
                             textBox3.Text = "";
                             textBox4.Text = "";
                             textBox5.Text = "";
                            textBox6.Text = "";
                            comboBox1.SelectedIndex = -1;
                            textBox7.Text = "";
                            textBox8.Text = "";
                            textBox9.Text = "";
                            maskedTextBox1.Text = "";

                        }
                    }
                    else { MessageBox.Show($"Passwords do not match"); }
                }
                catch (Exception ex) { MessageBox.Show($"There has been an error: {ex} "); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager eo = new Manager(userime, Userid);
            eo.FormClosed += (s, args) => this.Close();
            this.Hide();
            eo.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            x++;

            if (x % 2 == 0)
            {

                button3.BackgroundImage = Properties.Resources.hidden_12197891;
                textBox5.UseSystemPasswordChar = true;
                textBox6.UseSystemPasswordChar = true;

            }
            else
            {
                button3.BackgroundImage = Properties.Resources.sifravidi;
                textBox5.UseSystemPasswordChar = false;
                textBox6.UseSystemPasswordChar = false;

            }
        }
    }
}
