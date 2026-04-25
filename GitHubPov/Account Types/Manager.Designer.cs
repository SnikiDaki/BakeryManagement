namespace GitHubPov.Account_Type_s
{
    partial class Manager
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(138, 90, 60);
            button1.Font = new Font("Segoe Script", 18F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(249, 190, 189);
            button1.Location = new Point(251, 58);
            button1.Name = "button1";
            button1.Size = new Size(458, 72);
            button1.TabIndex = 0;
            button1.Text = "Employee Overview";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(138, 90, 60);
            button2.Font = new Font("Segoe Script", 18F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(249, 190, 189);
            button2.Location = new Point(251, 197);
            button2.Name = "button2";
            button2.Size = new Size(458, 72);
            button2.TabIndex = 1;
            button2.Text = "Task Overview\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(138, 90, 60);
            button3.Font = new Font("Segoe Script", 18F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(249, 190, 189);
            button3.Location = new Point(251, 325);
            button3.Name = "button3";
            button3.Size = new Size(458, 72);
            button3.TabIndex = 2;
            button3.Text = "Register A New Employee";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(138, 90, 60);
            button4.Font = new Font("Segoe Script", 18F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(249, 190, 189);
            button4.Location = new Point(251, 458);
            button4.Name = "button4";
            button4.Size = new Size(458, 72);
            button4.TabIndex = 3;
            button4.Text = "Income Check";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(138, 90, 60);
            button5.Font = new Font("Segoe Script", 18F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(249, 190, 189);
            button5.Location = new Point(857, 58);
            button5.Name = "button5";
            button5.Size = new Size(128, 72);
            button5.TabIndex = 0;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 196, 138);
            ClientSize = new Size(997, 577);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button1);
            Name = "Manager";
            Text = "Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}