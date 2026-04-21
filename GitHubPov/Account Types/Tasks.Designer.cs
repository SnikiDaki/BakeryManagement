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
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All" });
            comboBox2.Location = new Point(935, 85);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Completed", "Not Completed", "Awaiting For Approval" });
            comboBox1.Location = new Point(712, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 23);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(935, 52);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 11;
            label7.Text = "Cook Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(712, 52);
            label6.Name = "label6";
            label6.Size = new Size(127, 21);
            label6.TabIndex = 12;
            label6.Text = "Task Completion:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            ZadatakID.HeaderText = "TaskID";
            ZadatakID.Name = "ZadatakID";
            ZadatakID.ReadOnly = true;
            ZadatakID.Visible = false;
            // 
            // NarudzbaID
            // 
            NarudzbaID.HeaderText = "OrderID";
            NarudzbaID.Name = "NarudzbaID";
            NarudzbaID.ReadOnly = true;
            NarudzbaID.Visible = false;
            // 
            // imetorte
            // 
            imetorte.HeaderText = "Cake Name";
            imetorte.Name = "imetorte";
            imetorte.ReadOnly = true;
            // 
            // kukname
            // 
            kukname.HeaderText = "Cook Name";
            kukname.Name = "kukname";
            kukname.ReadOnly = true;
            // 
            // Statustorte
            // 
            Statustorte.HeaderText = "Status";
            Statustorte.Name = "Statustorte";
            Statustorte.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(408, 52);
            label2.Name = "label2";
            label2.Size = new Size(183, 37);
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
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 465);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 12;
            label1.Text = "Task Image:";
            // 
            // button1
            // 
            button1.Location = new Point(555, 719);
            button1.Name = "button1";
            button1.Size = new Size(90, 39);
            button1.TabIndex = 16;
            button1.Text = "Approve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(703, 719);
            button2.Name = "button2";
            button2.Size = new Size(90, 39);
            button2.TabIndex = 16;
            button2.Text = "Deny";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(851, 719);
            button3.Name = "button3";
            button3.Size = new Size(90, 39);
            button3.TabIndex = 16;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private DataGridViewTextBoxColumn ZadatakID;
        private DataGridViewTextBoxColumn NarudzbaID;
        private DataGridViewTextBoxColumn imetorte;
        private DataGridViewTextBoxColumn kukname;
        private DataGridViewTextBoxColumn Statustorte;
        private Button button3;
    }
}