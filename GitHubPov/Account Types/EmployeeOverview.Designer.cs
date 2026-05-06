namespace GitHubPov.Account_Types
{
    partial class EmployeeOverview
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            EmployeeID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            EmployeeLastName = new DataGridViewTextBoxColumn();
            EmployeeUserName = new DataGridViewTextBoxColumn();
            EmployeeRole = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox5 = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(183, 196, 138);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, EmployeeName, EmployeeLastName, EmployeeUserName, EmployeeRole });
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1132, 237);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // EmployeeID
            // 
            dataGridViewCellStyle6.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeID.DefaultCellStyle = dataGridViewCellStyle6;
            EmployeeID.HeaderText = "EmployeeID";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            EmployeeID.Visible = false;
            // 
            // EmployeeName
            // 
            dataGridViewCellStyle7.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            EmployeeName.DefaultCellStyle = dataGridViewCellStyle7;
            EmployeeName.HeaderText = "Employee FirstName";
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            // 
            // EmployeeLastName
            // 
            dataGridViewCellStyle8.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            EmployeeLastName.DefaultCellStyle = dataGridViewCellStyle8;
            EmployeeLastName.HeaderText = "Employee LastName";
            EmployeeLastName.Name = "EmployeeLastName";
            EmployeeLastName.ReadOnly = true;
            // 
            // EmployeeUserName
            // 
            dataGridViewCellStyle9.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            EmployeeUserName.DefaultCellStyle = dataGridViewCellStyle9;
            EmployeeUserName.HeaderText = "Employee Username";
            EmployeeUserName.Name = "EmployeeUserName";
            EmployeeUserName.ReadOnly = true;
            // 
            // EmployeeRole
            // 
            dataGridViewCellStyle10.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            EmployeeRole.DefaultCellStyle = dataGridViewCellStyle10;
            EmployeeRole.HeaderText = "Employee Role";
            EmployeeRole.Name = "EmployeeRole";
            EmployeeRole.ReadOnly = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(110, 365);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(138, 90, 60);
            label1.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(249, 190, 189);
            label1.Location = new Point(544, 321);
            label1.Name = "label1";
            label1.Size = new Size(95, 27);
            label1.TabIndex = 2;
            label1.Text = "More Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(138, 90, 60);
            label2.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(249, 190, 189);
            label2.Location = new Point(490, 24);
            label2.Name = "label2";
            label2.Size = new Size(178, 27);
            label2.TabIndex = 2;
            label2.Text = "Employee Overview";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(138, 90, 60);
            label3.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(249, 190, 189);
            label3.Location = new Point(15, 368);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 3;
            label3.Text = "First Name:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            textBox2.ForeColor = SystemColors.ControlText;
            textBox2.Location = new Point(110, 423);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(138, 90, 60);
            label4.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(249, 190, 189);
            label4.Location = new Point(18, 429);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Last Name:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            textBox3.ForeColor = SystemColors.ControlText;
            textBox3.Location = new Point(365, 368);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(138, 90, 60);
            label5.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(249, 190, 189);
            label5.Location = new Point(279, 371);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 3;
            label5.Text = "Username:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            textBox4.ForeColor = SystemColors.ControlText;
            textBox4.Location = new Point(365, 423);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(138, 90, 60);
            label7.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(249, 190, 189);
            label7.Location = new Point(292, 429);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 3;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(138, 90, 60);
            label6.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(249, 190, 189);
            label6.Location = new Point(569, 371);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 3;
            label6.Text = "Role:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(138, 90, 60);
            label8.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(249, 190, 189);
            label8.Location = new Point(529, 429);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 3;
            label8.Text = "Phone Number:";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            textBox7.ForeColor = SystemColors.ControlText;
            textBox7.Location = new Point(896, 358);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 30);
            textBox7.TabIndex = 1;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            textBox8.ForeColor = SystemColors.ControlText;
            textBox8.Location = new Point(896, 417);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 30);
            textBox8.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(138, 90, 60);
            label9.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(249, 190, 189);
            label9.Location = new Point(825, 367);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 3;
            label9.Text = "Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(138, 90, 60);
            label10.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(249, 190, 189);
            label10.Location = new Point(841, 423);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 3;
            label10.Text = "City:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(138, 90, 60);
            button1.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(249, 190, 189);
            button1.Location = new Point(30, 494);
            button1.Name = "button1";
            button1.Size = new Size(109, 44);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(138, 90, 60);
            button2.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(249, 190, 189);
            button2.Location = new Point(1035, 494);
            button2.Name = "button2";
            button2.Size = new Size(109, 44);
            button2.TabIndex = 4;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cashier", "Cook", "Courier", "Accountant" });
            comboBox1.Location = new Point(654, 362);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 31);
            comboBox1.TabIndex = 29;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            maskedTextBox1.Location = new Point(654, 421);
            maskedTextBox1.Mask = "(+999) 00-0000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 30);
            maskedTextBox1.TabIndex = 30;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            textBox5.ForeColor = SystemColors.ControlText;
            textBox5.Location = new Point(1196, 358);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 30);
            textBox5.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(138, 90, 60);
            label11.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(249, 190, 189);
            label11.Location = new Point(1062, 364);
            label11.Name = "label11";
            label11.Size = new Size(115, 20);
            label11.TabIndex = 3;
            label11.Text = "House Number:";
            // 
            // EmployeeOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 196, 138);
            ClientSize = new Size(1358, 550);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox8);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EmployeeOverview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Overview";
            Load += EmployeeOverview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label7;
        private Label label6;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label9;
        private Label label10;
        private Button button1;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmployeeLastName;
        private DataGridViewTextBoxColumn EmployeeUserName;
        private DataGridViewTextBoxColumn EmployeeRole;
        private Button button2;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox5;
        private Label label11;
    }
}