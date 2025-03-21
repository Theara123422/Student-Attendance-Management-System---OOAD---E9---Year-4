namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class TeacherClassesPage
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
            ActiveTeacherLabel = new Label();
            dgv_teacher_classes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Label = new DataGridViewTextBoxColumn();
            Section = new DataGridViewTextBoxColumn();
            BelongTo = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_teacher_classes).BeginInit();
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
            panel1.Size = new Size(1018, 50);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(204, 23);
            label2.TabIndex = 0;
            label2.Text = "Teacher Class Page";
            // 
            // ActiveTeacherLabel
            // 
            ActiveTeacherLabel.AutoSize = true;
            ActiveTeacherLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActiveTeacherLabel.ForeColor = Color.DodgerBlue;
            ActiveTeacherLabel.Location = new Point(13, 69);
            ActiveTeacherLabel.Name = "ActiveTeacherLabel";
            ActiveTeacherLabel.Size = new Size(188, 23);
            ActiveTeacherLabel.TabIndex = 22;
            ActiveTeacherLabel.Text = "All active class of ";
            // 
            // dgv_teacher_classes
            // 
            dgv_teacher_classes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_teacher_classes.Columns.AddRange(new DataGridViewColumn[] { Id, Label, Section, BelongTo });
            dgv_teacher_classes.Location = new Point(13, 111);
            dgv_teacher_classes.Name = "dgv_teacher_classes";
            dgv_teacher_classes.RowHeadersWidth = 51;
            dgv_teacher_classes.Size = new Size(993, 507);
            dgv_teacher_classes.TabIndex = 23;
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
            // TeacherClassesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 630);
            Controls.Add(dgv_teacher_classes);
            Controls.Add(ActiveTeacherLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherClassesPage";
            Text = "TeacherClassesPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_teacher_classes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label ActiveTeacherLabel;
        private DataGridView dgv_teacher_classes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Label;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn BelongTo;
    }
}