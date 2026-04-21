using GitHubPov.Account_Type_s;
using GitHubPov.Properties;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GitHubPov.Account_Types.Customer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GitHubPov.Account_Types
{
    public partial class Tasks : Form
    {
        public string userime;
        public int Userid;
        public int Taskid;
        public int Orderid;
        public Tasks(string username, int userid)
        {
            InitializeComponent();
            userime = username;
            Userid = userid;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "Select firstname, lastname from users where role ='cook';";
                MySqlCommand cmd = new MySqlCommand(select, conn);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    comboBox2.Items.Add(dr[0].ToString() + " " + dr[1].ToString());

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror:" + ex);
            }

        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "Select t.*, o.orderid from tasks t inner join orders o on t.orderid = o.orderid;";
                MySqlCommand cmd = new MySqlCommand(select, conn);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    dataGridView1.Rows.Add(dr["taskid"].ToString(), dr["orderid"].ToString(), dr["cakename"].ToString(), dr["cookname"].ToString(), dr["statustask"].ToString());
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
                Taskid = Convert.ToInt32(row.Cells["ZadatakID"].Value);
                Orderid = Convert.ToInt32(row.Cells["NarudzbaID"].Value);

                string select = "Select picture from tasks where taskid=@taskid;";

                MySqlCommand cmd = new MySqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@taskid", Taskid);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string putanja = dr["picture"].ToString();

                    if (putanja == "")
                    {
                        pictureBox1.Image = Properties.Resources.noimg;

                    }
                    else
                    {
                        pictureBox1.ImageLocation = putanja;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror:" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {

                string updejt = "update tasks set statustask='Completed' WHERE taskid=@taskid;";
                MySqlCommand cmd = new MySqlCommand(updejt, conn);
                cmd.Parameters.AddWithValue("@taskid", Taskid);
                int p = cmd.ExecuteNonQuery();
                if (p > 0)
                {

                    MessageBox.Show("Task Approved!", "Task");
                    Tasks_Load(sender,e);

                }

                string selekcija = "select count(orderid) from tasks where orderid=@orderid and statustask!='Completed'";
                MySqlCommand cmd3 = new MySqlCommand(selekcija, conn);
                cmd3.Parameters.AddWithValue("@orderid", Orderid);
                int taskovi = Convert.ToInt32(cmd3.ExecuteScalar());
                if (taskovi == 0) {
                    string updejt2 = "update orders set chefstatus='Completed', status='Waiting For Courier' WHERE orderid=@orderid;";
                    MySqlCommand cmd2 = new MySqlCommand(updejt2, conn);
                    cmd2.Parameters.AddWithValue("@orderid", Orderid);
                    cmd2.ExecuteNonQuery();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror:" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string updejt = "update tasks set statustask='Not Completed' WHERE taskid=@taskid;";
                MySqlCommand cmd = new MySqlCommand(updejt, conn);
                cmd.Parameters.AddWithValue("@taskid", Taskid);
                int p = cmd.ExecuteNonQuery();
                if (p > 0)
                {

                    string updejt2 = "update orders set chefstatus='Not Completed', status='Pending' WHERE orderid=@orderid;";
                    MySqlCommand cmd2 = new MySqlCommand(updejt2, conn);
                    cmd2.Parameters.AddWithValue("@orderid", Orderid);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Task Denied!", "Task");
                    Tasks_Load(sender, e);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror:" + ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "Select * from tasks where (@status= 'All' or statustask=@status) and (@cakename= 'All' or cookname=@cakename);";
                MySqlCommand cmd = new MySqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@status", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@cakename", comboBox2.SelectedItem);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string produkt = dr["cakename"].ToString();
                    string cookname = dr["cookname"].ToString();
                    //  int quantity = Convert.ToInt32(dr["quantity"]);
                    int orderid = Convert.ToInt32(dr["orderid"]);
                    string status = dr["statustask"].ToString();
                    int taskid = Convert.ToInt32(dr["taskid"]);


                    dataGridView1.Rows.Add(orderid, taskid, produkt, cookname, status);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror:" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        
            Manager eo = new Manager(userime, Userid);
            eo.FormClosed += (s, args) => this.Close();
            this.Hide();
            eo.Show();
        
    }
    }
}
