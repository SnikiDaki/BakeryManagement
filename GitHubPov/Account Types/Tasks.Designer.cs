namespace GitHubPov.Account_Types
{
    partial class Tasks
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ZadatakID = new DataGridViewTextBoxColumn();
            NarudzbaID = new DataGridViewTextBoxColumn();
            imetorte = new DataGridViewTextBoxColumn();
            kukname = new DataGridViewTextBoxColumn();
            Statustorte = new DataGridViewTextBoxColumn();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All" });
            comboBox2.Location = new Point(982, 85);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 31);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Completed", "Not Completed", "Awaiting For Approval" });
            comboBox1.Location = new Point(760, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 31);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(138, 90, 60);
            label7.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(249, 190, 189);
            label7.Location = new Point(993, 52);
            label7.Name = "label7";
            label7.Size = new Size(110, 27);
            label7.TabIndex = 11;
            label7.Text = "Cook Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(138, 90, 60);
            label6.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(249, 190, 189);
            label6.Location = new Point(728, 52);
            label6.Name = "label6";
            label6.Size = new Size(159, 27);
            label6.TabIndex = 12;
            label6.Text = "Task Completion:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(183, 196, 138);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ZadatakID, NarudzbaID, imetorte, kukname, Statustorte });
            dataGridView1.Location = new Point(12, 125);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1155, 313);
            dataGridView1.TabIndex = 10;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // ZadatakID
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ZadatakID.DefaultCellStyle = dataGridViewCellStyle1;
            ZadatakID.HeaderText = "TaskID";
            ZadatakID.Name = "ZadatakID";
            ZadatakID.ReadOnly = true;
            ZadatakID.Visible = false;
            // 
            // NarudzbaID
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            NarudzbaID.DefaultCellStyle = dataGridViewCellStyle2;
            NarudzbaID.HeaderText = "OrderID";
            NarudzbaID.Name = "NarudzbaID";
            NarudzbaID.ReadOnly = true;
            NarudzbaID.Visible = false;
            // 
            // imetorte
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            imetorte.DefaultCellStyle = dataGridViewCellStyle3;
            imetorte.HeaderText = "Cake Name";
            imetorte.Name = "imetorte";
            imetorte.ReadOnly = true;
            // 
            // kukname
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            kukname.DefaultCellStyle = dataGridViewCellStyle4;
            kukname.HeaderText = "Cook Name";
            kukname.Name = "kukname";
            kukname.ReadOnly = true;
            // 
            // Statustorte
            // 
            dataGridViewCellStyle5.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            Statustorte.DefaultCellStyle = dataGridViewCellStyle5;
            Statustorte.HeaderText = "Status";
            Statustorte.Name = "Statustorte";
            Statustorte.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(138, 90, 60);
            label2.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(249, 190, 189);
            label2.Location = new Point(408, 52);
            label2.Name = "label2";
            label2.Size = new Size(229, 44);
            label2.TabIndex = 8;
            label2.Text = "Task Overview";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 507);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(138, 90, 60);
            label1.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(249, 190, 189);
            label1.Location = new Point(12, 465);
            label1.Name = "label1";
            label1.Size = new Size(110, 27);
            label1.TabIndex = 12;
            label1.Text = "Task Image:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(138, 90, 60);
            button1.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(249, 190, 189);
            button1.Location = new Point(555, 719);
            button1.Name = "button1";
            button1.Size = new Size(95, 39);
            button1.TabIndex = 16;
            button1.Text = "Approve";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(138, 90, 60);
            button2.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(249, 190, 189);
            button2.Location = new Point(703, 719);
            button2.Name = "button2";
            button2.Size = new Size(90, 39);
            button2.TabIndex = 16;
            button2.Text = "Deny";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(138, 90, 60);
            button3.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(249, 190, 189);
            button3.Location = new Point(851, 719);
            button3.Name = "button3";
            button3.Size = new Size(90, 39);
            button3.TabIndex = 16;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 196, 138);
            ClientSize = new Size(1174, 770);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "Tasks";
            Text = "Tasks";
            Load += Tasks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn ZadatakID;
        private DataGridViewTextBoxColumn NarudzbaID;
        private DataGridViewTextBoxColumn imetorte;
        private DataGridViewTextBoxColumn kukname;
        private DataGridViewTextBoxColumn Statustorte;
    }
}