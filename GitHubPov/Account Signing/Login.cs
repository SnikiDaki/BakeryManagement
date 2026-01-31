
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using GitHubPov.Account_Types;
namespace GitHubPov
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        public static class Db
        {
            public static string konekcija = "Server=metro.proxy.rlwy.net;Port=20149;Database=railway;Uid=root;Pwd=mvxRtenxTQfNKFjrBnYNlhViwjyupHiS;SSLMode=Required;Connection Timeout=30;";
        }


        private void Login_Load(object sender, EventArgs e)
        {
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

             
        MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "SELECT * FROM users WHERE username = @username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(select, conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows) {
                    MessageBox.Show($"Login Successful!\nWelcome, {username}!", "Login");
                    Customer customer = new Customer(username);
                    this.Hide();
                    customer.Show();
                }
                else { MessageBox.Show($"Username or password is incorrect.", "Login"); }
            }
            catch (Exception ex) { MessageBox.Show($"Doslo je do greske: {ex} "); }
        }

    }
}
