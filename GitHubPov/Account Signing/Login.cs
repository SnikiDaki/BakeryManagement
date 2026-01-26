
using Npgsql;

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


        
        
            
            

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            
           string konekcija = "server=db.hwxqtaqoebbpmtnrormo.supabase.co;user=postgres;password=SDBmenigment958;database=postgres;SSL Mode=Require;Trust Server Certificate=true";
            NpgsqlConnection conn = new NpgsqlConnection(konekcija);

            try
            {
                string select = "SELECT * FROM users WHERE username = @username AND password=@password";
                NpgsqlCommand cmd = new NpgsqlCommand(select, conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
            }
            catch (Exception ex) { MessageBox.Show($"Doslo je do greske: {ex} "); }
        }
    }
}
