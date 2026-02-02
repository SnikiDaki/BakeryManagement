namespace GitHubPov.CustomerData
{
    partial class Cart
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
            label4 = new Label();
            listView1 = new ListView();
            PN = new ColumnHeader();
            P = new ColumnHeader();
            Q = new ColumnHeader();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(193, 9);
            label4.Name = "label4";
            label4.Size = new Size(126, 37);
            label4.TabIndex = 3;
            label4.Text = "Your Cart";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { PN, P, Q });
            listView1.Location = new Point(12, 70);
            listView1.Name = "listView1";
            listView1.Size = new Size(528, 223);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // PN
            // 
            PN.Text = "Product Name";
            PN.Width = 150;
            // 
            // P
            // 
            P.Text = "Price $";
            P.Width = 150;
            // 
            // Q
            // 
            Q.Text = "Quantity";
            Q.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(343, 307);
            button1.Name = "button1";
            button1.Size = new Size(197, 34);
            button1.TabIndex = 6;
            button1.Text = "Continue To Payment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 305);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 7;
            label1.Text = "Total :";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 510);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label4);
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private ListView listView1;
        private Button button1;
        private ColumnHeader PN;
        private ColumnHeader P;
        private ColumnHeader Q;
        private Label label1;
    }
}