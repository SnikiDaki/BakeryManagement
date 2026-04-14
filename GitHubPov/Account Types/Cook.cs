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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GitHubPov.Account_Type_s
{
    public partial class Cook : Form
    {
        public string user;
        public int Uid;
        public int index;
        public string putanja = "";
        public string cakename;
        public int orderid;
        public int orderid2;
        public string status;
        public string produkt;

        public Cook(string username, int userid)
        {
            InitializeComponent();
            Uid = userid;
            user = username;
            button3.Enabled = false;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            // comboBox1.Items.Clear();
            
            

        }
        public static class Db
        {
            public static string konekcija = "server=localhost;user=root;password=;database=bakery";
            // public static string konekcija = "Server=metro.proxy.rlwy.net;Port=20149;Database=railway;Uid=root;Pwd=mvxRtenxTQfNKFjrBnYNlhViwjyupHiS;SSLMode=Required;Connection Timeout=30;";
        }
        private void Cook_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "Select * from orders;";
                MySqlCommand cmd = new MySqlCommand(select, conn);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    produkt = dr["product"].ToString();
                    int quantity = Convert.ToInt32(dr["quantity"]);
                    orderid = Convert.ToInt32(dr["orderid"]);
                    status = dr["chefstatus"].ToString();
                    comboBox2.Items.Add(produkt);

                    dataGridView1.Rows.Add(orderid, produkt, quantity, status);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror:" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                button3.Enabled = true;
                MessageBox.Show("Task Started, Good Luck!", "Task");
                dataGridView1.Enabled = false;
                button1.Enabled = false;
                label8.Text = $"Started Task ID: {orderid}";
            }
            else { MessageBox.Show("Task Not Selected!", "Task"); }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            //index = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CakeName"].Value);
            DataGridViewRow row = dataGridView1.CurrentRow;
            cakename = row.Cells["imetorte"].Value.ToString();
            if (cakename == null) return;
            orderid2 = Convert.ToInt32(row.Cells["order"].Value);

            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "Select ingredients from cakes WHERE cakename=@cakename;";
                MySqlCommand cmd = new MySqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@cakename", cakename);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string ingredients = dr["ingredients"].ToString();
                    richTextBox1.Text = ingredients;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror:" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (putanja != "")
            {
                MessageBox.Show("Task Completed!", "Task");
                label8.Text = $"Started Task ID: None";
                MySqlConnection conn = new MySqlConnection(Db.konekcija);
                conn.Open();
                try
                {
                    string insert = "INSERT INTO tasks(cakename,cookname,picture, statustask) VALUES(@cakename,@cookname,@picture, 'Completed');";
                    MySqlCommand cmd = new MySqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@cakename", cakename);
                    cmd.Parameters.AddWithValue("@cookname", user);
                    cmd.Parameters.AddWithValue("@picture", putanja);
                    int p = cmd.ExecuteNonQuery();
                    if (p > 0)
                    {
                        string update = "update orders set status='Waiting For Courier', chefstatus='Completed' where orderid=@orderid";
                        MySqlCommand cmd2 = new MySqlCommand(update, conn);
                        cmd2.Parameters.AddWithValue("@orderid", orderid2);
                        cmd2.ExecuteNonQuery();

                        button1.Enabled = true;
                        button3.Enabled = false;
                        dataGridView1.Enabled = true;
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eror:" + ex);
                }


            }
            else
            {
                MessageBox.Show("Upload a photo of your task before finishing!", "Task");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a picture to complete the task!";
            ofd.Filter = "Pictures (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                putanja = "";
                return;
            }
            else
            {
                putanja = ofd.FileName;

                pictureBox1.ImageLocation = putanja;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();

            MySqlConnection conn = new MySqlConnection(Db.konekcija);
            conn.Open();
            try
            {
                string select = "Select * from orders where (@status= 'All' or chefstatus=@status) and (@cakename= 'All' or product=@cakename);";
                MySqlCommand cmd = new MySqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@status", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@cakename", comboBox2.SelectedItem);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    produkt = dr["product"].ToString();
                    int quantity = Convert.ToInt32(dr["quantity"]);
                    orderid = Convert.ToInt32(dr["orderid"]);
                    status = dr["chefstatus"].ToString();
                    

                    dataGridView1.Rows.Add(orderid, produkt, quantity, status);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror:" + ex);
            }
        }

        
    }
}
