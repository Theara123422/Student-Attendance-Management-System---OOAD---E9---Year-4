namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class AttendanceForm
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            dgv_attendance_student = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Section = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_attendance_student).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 50);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(188, 23);
            label2.TabIndex = 0;
            label2.Text = "Attendance Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(231, 23);
            label1.TabIndex = 6;
            label1.Text = "All Student of Class M1";
            // 
            // dgv_attendance_student
            // 
            dgv_attendance_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_attendance_student.Columns.AddRange(new DataGridViewColumn[] { Id, StudentName, Section, Status });
            dgv_attendance_student.Location = new Point(12, 111);
            dgv_attendance_student.Name = "dgv_attendance_student";
            dgv_attendance_student.RowHeadersWidth = 51;
            dgv_attendance_student.Size = new Size(958, 413);
            dgv_attendance_student.TabIndex = 7;
            dgv_attendance_student.CellClick += dgv_attendance_student_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.Width = 400;
            // 
            // Section
            // 
            Section.HeaderText = "Section";
            Section.MinimumWidth = 6;
            Section.Name = "Section";
            Section.Width = 200;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 536);
            Controls.Add(dgv_attendance_student);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AttendanceForm";
            Text = "AttendanceForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_attendance_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private DataGridView dgv_attendance_student;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn Status;
    }
}