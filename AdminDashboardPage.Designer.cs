namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class AdminDashboardPage
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            dgvAdminDashboard = new DataGridView();
            cl_id = new DataGridViewTextBoxColumn();
            cl_name = new DataGridViewTextBoxColumn();
            cl_depart = new DataGridViewTextBoxColumn();
            cl_prof = new DataGridViewTextBoxColumn();
            cl_stu_amount = new DataGridViewTextBoxColumn();
            cl_status = new DataGridViewTextBoxColumn();
            all_class_btn = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminDashboard).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(247, 23);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(162, 23);
            label2.TabIndex = 1;
            label2.Text = "All Active Class";
            // 
            // dgvAdminDashboard
            // 
            dgvAdminDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminDashboard.Columns.AddRange(new DataGridViewColumn[] { cl_id, cl_name, cl_depart, cl_prof, cl_stu_amount, cl_status });
            dgvAdminDashboard.Location = new Point(12, 117);
            dgvAdminDashboard.Name = "dgvAdminDashboard";
            dgvAdminDashboard.RowHeadersWidth = 51;
            dgvAdminDashboard.Size = new Size(1012, 517);
            dgvAdminDashboard.TabIndex = 3;
            // 
            // cl_id
            // 
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cl_id.DefaultCellStyle = dataGridViewCellStyle1;
            cl_id.HeaderText = "Id";
            cl_id.MinimumWidth = 6;
            cl_id.Name = "cl_id";
            cl_id.Resizable = DataGridViewTriState.False;
            cl_id.Width = 175;
            // 
            // cl_name
            // 
            cl_name.HeaderText = "Name";
            cl_name.MinimumWidth = 6;
            cl_name.Name = "cl_name";
            cl_name.Width = 175;
            // 
            // cl_depart
            // 
            cl_depart.HeaderText = "Department";
            cl_depart.MinimumWidth = 6;
            cl_depart.Name = "cl_depart";
            cl_depart.Width = 175;
            // 
            // cl_prof
            // 
            cl_prof.HeaderText = "Prof.";
            cl_prof.MinimumWidth = 6;
            cl_prof.Name = "cl_prof";
            cl_prof.Width = 175;
            // 
            // cl_stu_amount
            // 
            cl_stu_amount.HeaderText = "Stu. Amount";
            cl_stu_amount.MinimumWidth = 6;
            cl_stu_amount.Name = "cl_stu_amount";
            cl_stu_amount.Width = 125;
            // 
            // cl_status
            // 
            cl_status.HeaderText = "Status";
            cl_status.MinimumWidth = 6;
            cl_status.Name = "cl_status";
            cl_status.Width = 132;
            // 
            // all_class_btn
            // 
            all_class_btn.AutoSize = true;
            all_class_btn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            all_class_btn.ForeColor = Color.DodgerBlue;
            all_class_btn.ImageAlign = ContentAlignment.MiddleRight;
            all_class_btn.Location = new Point(952, 71);
            all_class_btn.Name = "all_class_btn";
            all_class_btn.Size = new Size(69, 19);
            all_class_btn.TabIndex = 2;
            all_class_btn.Text = "See all ";
            all_class_btn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AdminDashboardPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 646);
            Controls.Add(dgvAdminDashboard);
            Controls.Add(all_class_btn);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboardPage";
            Text = "AdminDashboardPage";
            TopMost = true;
            Load += AdminDashboardPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminDashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private DataGridView dgvAdminDashboard;
        private Label all_class_btn;
        private DataGridViewTextBoxColumn cl_id;
        private DataGridViewTextBoxColumn cl_name;
        private DataGridViewTextBoxColumn cl_depart;
        private DataGridViewTextBoxColumn cl_prof;
        private DataGridViewTextBoxColumn cl_stu_amount;
        private DataGridViewTextBoxColumn cl_status;
    }
}