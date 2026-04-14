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
            dataGridView1 = new DataGridView();
            EmployeeName = new DataGridViewTextBoxColumn();
            EmployeeLastName = new DataGridViewTextBoxColumn();
            EmployeeUserName = new DataGridViewTextBoxColumn();
            EmployeeRole = new DataGridViewTextBoxColumn();
            ClockedIn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeName, EmployeeLastName, EmployeeUserName, EmployeeRole, ClockedIn });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1132, 237);
            dataGridView1.TabIndex = 0;
            // 
            // EmployeeName
            // 
            EmployeeName.HeaderText = "Employee FirstName";
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            // 
            // EmployeeLastName
            // 
            EmployeeLastName.HeaderText = "Employee LastName";
            EmployeeLastName.Name = "EmployeeLastName";
            EmployeeLastName.ReadOnly = true;
            // 
            // EmployeeUserName
            // 
            EmployeeUserName.HeaderText = "Employee Username";
            EmployeeUserName.Name = "EmployeeUserName";
            EmployeeUserName.ReadOnly = true;
            // 
            // EmployeeRole
            // 
            EmployeeRole.HeaderText = "Employee Role";
            EmployeeRole.Name = "EmployeeRole";
            EmployeeRole.ReadOnly = true;
            // 
            // ClockedIn
            // 
            ClockedIn.HeaderText = "Clocked In";
            ClockedIn.Name = "ClockedIn";
            ClockedIn.ReadOnly = true;
            // 
            // EmployeeOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 550);
            Controls.Add(dataGridView1);
            Name = "EmployeeOverview";
            Text = "EmployeeOverview";
            Load += EmployeeOverview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmployeeLastName;
        private DataGridViewTextBoxColumn EmployeeUserName;
        private DataGridViewTextBoxColumn EmployeeRole;
        private DataGridViewTextBoxColumn ClockedIn;
    }
}