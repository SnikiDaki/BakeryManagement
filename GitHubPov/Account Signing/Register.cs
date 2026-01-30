using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
namespace GitHubPov
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            string username = textBox3.Text;
            string email = textBox4.Text;
            string password = textBox5.Text;

            string konekcija = "Host=bakerymanagement-bakerymanagement.g.aivencloud.com;Port=11884;Database=defaultdb;Username=avnadmin;Password=AVNS_6o1GMUTkYmgXdBdxJYy;SSL Mode=Require;Trust Server Certificate=true";
            MySqlConnection conn = new MySqlConnection(konekcija);

            try
            {
                conn.Open();
                string insert = "INSERT INTO users (firstname, lastname, username, email, password, role) VALUES (@firstname, @lastname, @username, @email, @password, 'customer')";
                MySqlCommand cmd = new MySqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@firstname", lastname);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show($"Doslo je do greske: {ex} "); }
        }

        
    }
}
