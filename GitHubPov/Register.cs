using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string konekcija = "Server=db.hwxqtaqoebbpmtnrormo.supabase.co;Username=postgres;Password=SDBmenigment958;Database=postgres;";
            NpgsqlConnection conn = new NpgsqlConnection(konekcija);
            conn.Open();

            try
            {
                string insert = "INSERT INTO users (firstname, lastname, username, email, password, role) VALUES (@firstname, @lastname, @username, @email, @password, 'customer')";
                NpgsqlCommand cmd = new NpgsqlCommand(insert, conn);
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
