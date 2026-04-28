namespace GitHubPov.Account_Types
{
    partial class CashierOrderInfo
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7 });
            dataGridView1.Location = new Point(51, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(686, 205);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "UserId";
            Column1.Name = "Column1";
            Column1.Width = 10;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe Print", 12F);
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.HeaderText = "Username";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe Print", 12F);
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "Product";
            Column3.Name = "Column3";
            Column3.Width = 175;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe Print", 12F);
            Column4.DefaultCellStyle = dataGridViewCellStyle4;
            Column4.HeaderText = "Quantity";
            Column4.Name = "Column4";
            Column4.Width = 70;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Font = new Font("Segoe Print", 12F);
            Column5.DefaultCellStyle = dataGridViewCellStyle5;
            Column5.HeaderText = "Info";
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column7
            // 
            dataGridViewCellStyle6.Font = new Font("Segoe Print", 12F);
            Column7.DefaultCellStyle = dataGridViewCellStyle6;
            Column7.HeaderText = "Date";
            Column7.Name = "Column7";
            Column7.Width = 140;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(138, 90, 60);
            label1.Font = new Font("Segoe Script", 12F);
            label1.ForeColor = Color.FromArgb(249, 190, 189);
            label1.Location = new Point(285, 18);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 1;
            label1.Text = "Finished Orders";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(138, 90, 60);
            label2.Font = new Font("Segoe Script", 12F);
            label2.ForeColor = Color.FromArgb(249, 190, 189);
            label2.Location = new Point(51, 277);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 2;
            label2.Text = "Selected Order:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column6 });
            dataGridView2.Location = new Point(51, 306);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(293, 207);
            dataGridView2.TabIndex = 3;
            // 
            // Column6
            // 
            dataGridViewCellStyle7.Font = new Font("Segoe Print", 12F);
            Column6.DefaultCellStyle = dataGridViewCellStyle7;
            Column6.HeaderText = "Product";
            Column6.Name = "Column6";
            Column6.Width = 250;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(138, 90, 60);
            button1.Font = new Font("Segoe Script", 12F);
            button1.ForeColor = Color.FromArgb(249, 190, 189);
            button1.Location = new Point(374, 479);
            button1.Name = "button1";
            button1.Size = new Size(101, 34);
            button1.TabIndex = 4;
            button1.Text = "Finish Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(138, 90, 60);
            textBox1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(249, 190, 189);
            textBox1.Location = new Point(374, 366);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(141, 36);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(138, 90, 60);
            label3.Font = new Font("Segoe Script", 12F);
            label3.ForeColor = Color.FromArgb(249, 190, 189);
            label3.Location = new Point(373, 338);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 6;
            label3.Text = "Username:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logobakery;
            pictureBox2.Location = new Point(570, 257);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(320, 281);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 74;
            pictureBox2.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(138, 90, 60);
            button5.Font = new Font("Segoe Script", 18F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(249, 190, 189);
            button5.Location = new Point(768, 12);
            button5.Name = "button5";
            button5.Size = new Size(113, 64);
            button5.TabIndex = 75;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // CashierOrderInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 196, 138);
            ClientSize = new Size(892, 538);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CashierOrderInfo";
            Text = "List of Orders";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private Button button5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
    }
}