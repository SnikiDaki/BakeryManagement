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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(473, 29);
            label1.Name = "label1";
            label1.Size = new Size(154, 37);
            label1.TabIndex = 0;
            label1.Text = "Cook Menu";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            order.HeaderText = "OrderID";
            order.Name = "order";
            order.ReadOnly = true;
            order.Visible = false;
            // 
            // Zadatak2ID
            // 
            Zadatak2ID.HeaderText = "Zadatak2ID";
            Zadatak2ID.Name = "Zadatak2ID";
            Zadatak2ID.ReadOnly = true;
            Zadatak2ID.Visible = false;
            // 
            // imetorte
            // 
            imetorte.HeaderText = "Cake Name";
            imetorte.Name = "imetorte";
            imetorte.ReadOnly = true;
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
            label2.Location = new Point(513, 80);
            label2.Name = "label2";
            label2.Size = new Size(77, 37);
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
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(112, 12);
            label4.Name = "label4";
            label4.Size = new Size(156, 37);
            label4.TabIndex = 2;
            label4.Text = "Ingredients:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(81, 789);
            label5.Name = "label5";
            label5.Size = new Size(350, 19);
            label5.TabIndex = 2;
            label5.Text = "Upload a picture when done, so you can start next task!";
            // 
            // button1
            // 
            button1.Location = new Point(434, 456);
            button1.Name = "button1";
            button1.Size = new Size(156, 40);
            button1.TabIndex = 4;
            button1.Text = "Start Selected Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button2
            // 
            button2.Location = new Point(81, 759);
            button2.Name = "button2";
            button2.Size = new Size(82, 27);
            button2.TabIndex = 4;
            button2.Text = "Open File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(79, 510);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 243);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(614, 456);
            button3.Name = "button3";
            button3.Size = new Size(156, 40);
            button3.TabIndex = 4;
            button3.Text = "Finish Task";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(79, 814);
            label3.Name = "label3";
            label3.Size = new Size(404, 19);
            label3.TabIndex = 2;
            label3.Text = "By clicking \"Finish Task\", you are aware that this can't be undone.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(798, 58);
            label6.Name = "label6";
            label6.Size = new Size(127, 21);
            label6.TabIndex = 6;
            label6.Text = "Task Completion:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Completed", "Not Completed", "Awaiting For Approval" });
            comboBox1.Location = new Point(798, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(1021, 58);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 6;
            label7.Text = "Cake:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All" });
            comboBox2.Location = new Point(1021, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.25F);
            label8.Location = new Point(792, 466);
            label8.Name = "label8";
            label8.Size = new Size(140, 19);
            label8.TabIndex = 0;
            label8.Text = "Started Task ID: None";
            // 
            // Cook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 845);
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
            Name = "Cook";
            Text = "Cook";
            Load += Cook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}