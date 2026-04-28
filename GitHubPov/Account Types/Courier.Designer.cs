namespace GitHubPov.Account_Type_s
{
    partial class Courier
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
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(138, 90, 60);
            button1.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(249, 190, 189);
            button1.Location = new Point(171, 189);
            button1.Name = "button1";
            button1.Size = new Size(458, 72);
            button1.TabIndex = 2;
            button1.Text = "View Deliveries";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(138, 90, 60);
            button9.Font = new Font("Segoe Script", 18F, FontStyle.Bold);
            button9.ForeColor = Color.FromArgb(249, 190, 189);
            button9.Location = new Point(650, 12);
            button9.Name = "button9";
            button9.Size = new Size(138, 49);
            button9.TabIndex = 73;
            button9.Text = "Logout";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // Courier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 196, 138);
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Courier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Courier";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button9;
    }
}