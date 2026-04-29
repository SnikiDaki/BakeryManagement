using GitHubPov.Account_Type_s;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CourierDeliveries : Form
    {
        public string userime;
        public int Userid;
        private bool isLoaded = false;
        public CourierDeliveries(string userime, int userid)
        {
            InitializeComponent();
            this.userime = userime;
            Userid = userid;

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            LoadOrders();

            isLoaded = true;
        }

        public static class Db
        {
            public static string konekcija = "server=localhost;user=root;password=;database=bakery";
        }

        private void LoadOrders()
        {
            dataGridView1.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(Db.konekcija))
            {
                conn.Open();

                string select = "SELECT orders.userid, users.username, orders.product, orders.quantity, orders.info, orders.date FROM orders JOIN users ON orders.userid = users.id WHERE orders.status = @status";
                MySqlCommand cmd = new MySqlCommand(select, conn);

                cmd.Parameters.AddWithValue("@status", "Waiting For Courier");

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(
                        dr["userid"],
                        dr["username"],
                        dr["product"],
                        dr["quantity"],
                        dr["info"],
                        dr["date"]
);
                }
            }
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            if (dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow.Index < 0) return;

            try
            {
                int selectedUserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DateTime selectedDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);

                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                dataGridView2.Rows.Clear();

                using (MySqlConnection conn = new MySqlConnection(Db.konekcija))
                {
                    conn.Open();

                    string query = "SELECT adresa FROM users WHERE id = @uid";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", selectedUserId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        textBox2.Text = result.ToString();
                    }
                    else
                    {
                        textBox2.Text = "";
                    }
                }

                using (MySqlConnection conn = new MySqlConnection(Db.konekcija))
                {
                    conn.Open();

                    string query = @"SELECT product FROM orders WHERE userid = @uid AND date = @date AND status = 'Waiting For Courier'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", selectedUserId);
                    cmd.Parameters.AddWithValue("@date", selectedDate.Date);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        dataGridView2.Rows.Add(dr["product"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("No order selected.");
                return;
            }

            int selectedUserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DateTime selectedDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);

            using (MySqlConnection conn = new MySqlConnection(Db.konekcija))
            {
                conn.Open();

                string query = @"UPDATE orders SET status = 'Order Delivered' WHERE userid = @uid AND date = @date AND status = 'Waiting For Courier'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", selectedUserId);
                cmd.Parameters.AddWithValue("@date", selectedDate.Date);

                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("Order Delivered");
            }

            LoadOrders();

            dataGridView2.Rows.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Courier c = new Courier(userime, Userid);
            c.FormClosed += (s, args) => this.Close();
            this.Hide();
            c.Show();
        }
    }
}
