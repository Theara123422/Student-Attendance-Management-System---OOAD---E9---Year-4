namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class MarkAttendancePage
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
            dgv_teacher_attendance = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Label = new DataGridViewTextBoxColumn();
            Section = new DataGridViewTextBoxColumn();
            BelongTo = new DataGridViewTextBoxColumn();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_teacher_attendance).BeginInit();
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
            panel1.Size = new Size(1000, 50);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(273, 23);
            label2.TabIndex = 0;
            label2.Text = "Teacher Attendance Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(13, 63);
            label1.Name = "label1";
            label1.Size = new Size(287, 23);
            label1.TabIndex = 5;
            label1.Text = "All Class for Morning Section";
            // 
            // dgv_teacher_attendance
            // 
            dgv_teacher_attendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_teacher_attendance.Columns.AddRange(new DataGridViewColumn[] { Id, Label, Section, BelongTo });
            dgv_teacher_attendance.Location = new Point(7, 105);
            dgv_teacher_attendance.Name = "dgv_teacher_attendance";
            dgv_teacher_attendance.RowHeadersWidth = 51;
            dgv_teacher_attendance.Size = new Size(981, 211);
            dgv_teacher_attendance.TabIndex = 24;
            dgv_teacher_attendance.CellClick += dgv_teacher_attendance_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Label
            // 
            Label.HeaderText = "Label";
            Label.MinimumWidth = 6;
            Label.Name = "Label";
            Label.Width = 215;
            // 
            // Section
            // 
            Section.HeaderText = "Section";
            Section.MinimumWidth = 6;
            Section.Name = "Section";
            Section.Width = 300;
            // 
            // BelongTo
            // 
            BelongTo.HeaderText = "Belong To";
            BelongTo.MinimumWidth = 6;
            BelongTo.Name = "BelongTo";
            BelongTo.Width = 300;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(163, 452);
            label3.Name = "label3";
            label3.Size = new Size(695, 23);
            label3.TabIndex = 25;
            label3.Text = "*** Click on the row cell in order to mark attendance for specific class";
            // 
            // MarkAttendancePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 583);
            Controls.Add(label3);
            Controls.Add(dgv_teacher_attendance);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MarkAttendancePage";
            Text = "MarkAttendancePage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_teacher_attendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private DataGridView dgv_teacher_attendance;
        private Label label3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Label;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn BelongTo;
    }
}