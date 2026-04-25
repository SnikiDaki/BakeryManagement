namespace GitHubPov.Account_Type_s
{
    partial class Cashier
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(138, 90, 60);
            button1.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(249, 190, 189);
            button1.Location = new Point(164, 117);
            button1.Name = "button1";
            button1.Size = new Size(458, 72);
            button1.TabIndex = 1;
            button1.Text = "View orders/Send out orders";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(138, 90, 60);
            button2.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(249, 190, 189);
            button2.Location = new Point(164, 249);
            button2.Name = "button2";
            button2.Size = new Size(458, 72);
            button2.TabIndex = 2;
            button2.Text = "Place a order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 196, 138);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Cashier";
            Text = "Cashier";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}