
using GitHubPov.Account_Type_s;
using GitHubPov.Account_Types;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace GitHubPov
{
    public partial class Login : Form
    {
        public string role;
        public int userid;
        public int x = 0;
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
            public static string konekcija = "server=localhost;user=root;password=;database=bakery";
            //public static string konekcija = "Server=metro.proxy.rlwy.net;Port=20149;Database=railway;Uid=root;Pwd=mvxRtenxTQfNKFjrBnYNlhViwjyupHiS;SSLMode=Required;Connection Timeout=30;";
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if(username == "" || password == "" )
            {
                MessageBox.Show($"Please fill out the required fields!", "Register");
            }
            else
            {
                
            
                MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "SELECT * FROM users WHERE username = @username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(select, conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    userid = Convert.ToInt32(dr[0]);
                    role = Convert.ToString(dr[6]);



                }
                if (dr.HasRows && role == "customer")
                {
                    MessageBox.Show($"Login Successful!\nWelcome, {username}!", "Login");
                    Customer customer = new Customer(username, userid);
                    customer.FormClosed += (s, args) => this.Close();
                    this.Hide();
                    customer.Show();
                }
                else if (dr.HasRows && role == "Cook")
                {
                    MessageBox.Show($"Login Successful!\nWelcome, {username}!", "Login");
                    Cook customer = new Cook(username, userid);
                    customer.FormClosed += (s, args) => this.Close();
                    this.Hide();
                    customer.Show();
                }
                else if (dr.HasRows && role == "Manager")
                {
                    MessageBox.Show($"Login Successful!\nWelcome, {username}!", "Login");
                    Manager customer = new Manager(username, userid);
                    customer.FormClosed += (s, args) => this.Close();
                    this.Hide();
                    customer.Show();
                }
                else { MessageBox.Show($"Username or password is incorrect.", "Login"); }
            }
            catch (Exception ex) { MessageBox.Show($"Doslo je do greske: {ex} "); }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x++;

            if (x % 2 == 0) {

                button2.BackgroundImage = Properties.Resources.hidden_12197891;
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                button2.BackgroundImage = Properties.Resources.sifravidi;
                textBox2.UseSystemPasswordChar = false;
            }

        }
    }
}
