using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using GitHubPov.Account_Types;
namespace GitHubPov
{
    public partial class Register : Form
    {
        public int x = 0;
        public Register()
        {
            InitializeComponent();
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

            if(firstname == "" || lastname =="" || username == "" || email == "" || password == "" || passcheck == "")
            {
                MessageBox.Show($"Please fill out the required fields!", "Register");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(Db.konekcija);

            conn.Open();
            try
            {
                string insert = "INSERT INTO users (firstname, lastname, username, email, password, role) VALUES (@firstname, @lastname, @username, @email, @password, 'customer')";
                MySqlCommand cmd = new MySqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                if (password == passcheck)
                {
                    int b = Convert.ToInt32(cmd.ExecuteNonQuery());
                    if (b == 1)
                    {
                        MessageBox.Show($"Registration successful!", "Register");
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                }
                else { MessageBox.Show($"Passwords do not match"); }
            }
            catch (Exception ex) { MessageBox.Show($"There has been an error: {ex} "); }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            x++;

            if (x % 2 == 0)
            {

                button2.BackgroundImage = Properties.Resources.hidden_12197891;
                textBox5.UseSystemPasswordChar = true;
                textBox6.UseSystemPasswordChar = true;

            }
            else
            {
                button2.BackgroundImage = Properties.Resources.sifravidi;
                textBox5.UseSystemPasswordChar = false;
                textBox6.UseSystemPasswordChar = false;

            }
        }
    }
}
