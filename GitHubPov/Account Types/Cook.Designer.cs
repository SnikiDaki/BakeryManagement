namespace GitHubPov.Account_Type_s
{
    partial class Cook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            order = new DataGridViewTextBoxColumn();
            Zadatak2ID = new DataGridViewTextBoxColumn();
            imetorte = new DataGridViewTextBoxColumn();
            Statustorte = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            label3 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            button9 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(138, 90, 60);
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(249, 190, 189);
            label1.Location = new Point(513, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 53);
            label1.TabIndex = 0;
            label1.Text = "Cook Menu";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(183, 196, 138);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { order, Zadatak2ID, imetorte, Statustorte });
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1155, 313);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // order
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order.DefaultCellStyle = dataGridViewCellStyle1;
            order.HeaderText = "Order ID";
            order.Name = "order";
            order.ReadOnly = true;
            // 
            // Zadatak2ID
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            Zadatak2ID.DefaultCellStyle = dataGridViewCellStyle2;
            Zadatak2ID.HeaderText = "Task ID";
            Zadatak2ID.Name = "Zadatak2ID";
            Zadatak2ID.ReadOnly = true;
            // 
            // imetorte
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            imetorte.DefaultCellStyle = dataGridViewCellStyle3;
            imetorte.HeaderText = "Cake Name";
            imetorte.Name = "imetorte";
            imetorte.ReadOnly = true;
            // 
            // Statustorte
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            Statustorte.DefaultCellStyle = dataGridViewCellStyle4;
            Statustorte.HeaderText = "Status";
            Statustorte.Name = "Statustorte";
            Statustorte.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(138, 90, 60);
            label2.Font = new Font("Segoe Script", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(249, 190, 189);
            label2.Location = new Point(553, 62);
            label2.Name = "label2";
            label2.Size = new Size(115, 53);
            label2.TabIndex = 0;
            label2.Text = "Tasks";
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(773, 510);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 323);
            panel1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            richTextBox1.Location = new Point(19, 68);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(361, 240);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(138, 90, 60);
            label4.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(249, 190, 189);
            label4.Location = new Point(112, 12);
            label4.Name = "label4";
            label4.Size = new Size(180, 44);
            label4.TabIndex = 2;
            label4.Text = "Ingredients:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(138, 90, 60);
            label5.Font = new Font("Segoe Script", 12F);
            label5.ForeColor = Color.FromArgb(249, 190, 189);
            label5.Location = new Point(76, 773);
            label5.Name = "label5";
            label5.Size = new Size(486, 25);
            label5.TabIndex = 2;
            label5.Text = "Upload a picture when done, so you can start next task!";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(138, 90, 60);
            button1.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(249, 190, 189);
            button1.Location = new Point(434, 456);
            button1.Name = "button1";
            button1.Size = new Size(156, 40);
            button1.TabIndex = 4;
            button1.Text = "Start Selected Task";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(138, 90, 60);
            button2.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(249, 190, 189);
            button2.Location = new Point(78, 705);
            button2.Name = "button2";
            button2.Size = new Size(86, 36);
            button2.TabIndex = 4;
            button2.Text = "Open File";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(76, 456);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 243);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(138, 90, 60);
            button3.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(249, 190, 189);
            button3.Location = new Point(614, 456);
            button3.Name = "button3";
            button3.Size = new Size(156, 40);
            button3.TabIndex = 4;
            button3.Text = "Finish Task";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(138, 90, 60);
            label3.Font = new Font("Segoe Script", 12F);
            label3.ForeColor = Color.FromArgb(249, 190, 189);
            label3.Location = new Point(76, 798);
            label3.Name = "label3";
            label3.Size = new Size(581, 25);
            label3.TabIndex = 2;
            label3.Text = "By clicking \"Finish Task\", you are aware that this can't be undone.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(138, 90, 60);
            label6.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(249, 190, 189);
            label6.Location = new Point(776, 45);
            label6.Name = "label6";
            label6.Size = new Size(159, 27);
            label6.TabIndex = 6;
            label6.Text = "Task Completion:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Completed", "Not Completed", "Awaiting For Approval" });
            comboBox1.Location = new Point(798, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 31);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(138, 90, 60);
            label7.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(249, 190, 189);
            label7.Location = new Point(1047, 45);
            label7.Name = "label7";
            label7.Size = new Size(56, 27);
            label7.TabIndex = 6;
            label7.Text = "Cake:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All" });
            comboBox2.Location = new Point(1021, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 31);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(138, 90, 60);
            label8.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(249, 190, 189);
            label8.Location = new Point(776, 462);
            label8.Name = "label8";
            label8.Size = new Size(196, 27);
            label8.TabIndex = 0;
            label8.Text = "Started Task ID: None";
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(138, 90, 60);
            button9.Font = new Font("Segoe Script", 18F, FontStyle.Bold);
            button9.ForeColor = Color.FromArgb(249, 190, 189);
            button9.Location = new Point(12, 14);
            button9.Name = "button9";
            button9.Size = new Size(138, 49);
            button9.TabIndex = 72;
            button9.Text = "Logout";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logobakery;
            pictureBox2.Location = new Point(466, 522);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(273, 206);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 73;
            pictureBox2.TabStop = false;
            // 
            // Cook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 196, 138);
            ClientSize = new Size(1179, 845);
            Controls.Add(pictureBox2);
            Controls.Add(button9);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Cook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cook";
            Load += Cook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label3;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private ComboBox comboBox2;
        private Label label8;
        private DataGridViewTextBoxColumn order;
        private DataGridViewTextBoxColumn Zadatak2ID;
        private DataGridViewTextBoxColumn imetorte;
        private DataGridViewTextBoxColumn Statustorte;
        private Button button9;
        private PictureBox pictureBox2;
    }
}