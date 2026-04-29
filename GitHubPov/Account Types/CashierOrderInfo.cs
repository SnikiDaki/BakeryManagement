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
    public partial class CashierOrderInfo : Form
    {
        public string userime;
        public int Userid;
        private bool isLoaded = false;
        public CashierOrderInfo(string userime, int userid)
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

                cmd.Parameters.AddWithValue("@status", "Ready To Pickup");

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
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

                    string query = @"SELECT product FROM orders WHERE userid = @uid AND date = @date AND status = 'Ready To Pickup'";

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

        private void button1_Click(object sender, EventArgs e)
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

                string query = @"UPDATE orders SET status = 'Order Completed' WHERE userid = @uid AND date = @date AND status = 'Ready To Pickup'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", selectedUserId);
                cmd.Parameters.AddWithValue("@date", selectedDate.Date);

                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("Order given out.");
            }

            LoadOrders();

            dataGridView2.Rows.Clear();
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cashier c = new Cashier(userime, Userid);
            c.FormClosed += (s, args) => this.Close();
            this.Hide();
            c.Show();
        }
    }
}

