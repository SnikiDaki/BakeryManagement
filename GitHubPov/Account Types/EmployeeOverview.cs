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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GitHubPov.Account_Types
{
    public partial class EmployeeOverview : Form
    {
        public string userime;
        public int Userid;

        public EmployeeOverview(string username, int id)
        {
            InitializeComponent();
            userime = username;
            Userid = id;
        }
        public static class Db
        {
            public static string konekcija = "server=localhost;user=root;password=;database=bakery";
            // public static string konekcija = "Server=metro.proxy.rlwy.net;Port=20149;Database=railway;Uid=root;Pwd=mvxRtenxTQfNKFjrBnYNlhViwjyupHiS;SSLMode=Required;Connection Timeout=30;";
        }

        private void EmployeeOverview_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "Select * from users WHERE role <> 'customer';";
                MySqlCommand cmd = new MySqlCommand(select, conn);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["id"].ToString(), dr["firstname"].ToString(), dr["lastname"].ToString(), dr["username"].ToString(), dr["role"].ToString());

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror:" + ex);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int idemp = Convert.ToInt32(row.Cells["EmployeeID"].Value);


                string select = "Select * from users WHERE role <> 'customer' AND id=@id;";
                MySqlCommand cmd = new MySqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@id", idemp);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = dr["firstname"].ToString();
                    textBox2.Text = dr["lastname"].ToString();
                    textBox3.Text = dr["username"].ToString();
                    textBox4.Text = dr["email"].ToString();
                    textBox5.Text = dr["role"].ToString();
                    textBox6.Text = dr["telefon"].ToString();
                    textBox7.Text = dr["adresa"].ToString();
                    textBox8.Text = dr["city"].ToString();




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror:" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager eo = new Manager(userime,Userid);
            eo.FormClosed += (s, args) => this.Close();
            this.Hide();
            eo.Show();
        }
    }
}
