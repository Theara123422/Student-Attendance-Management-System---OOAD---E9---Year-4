namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class AdminStudentPage
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
            label1 = new Label();
            label2 = new Label();
            StudentFirstName = new TextBox();
            label3 = new Label();
            StudentLastName = new TextBox();
            label4 = new Label();
            StudentGender = new ComboBox();
            label5 = new Label();
            StudentClass = new ComboBox();
            label6 = new Label();
            btn_update_student = new Button();
            btn_del_student = new Button();
            btn_edit_student = new Button();
            btn_insert_student = new Button();
            dgv_student = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_student).BeginInit();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(212, 23);
            label1.TabIndex = 0;
            label1.Text = "Admin Student Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(13, 77);
            label2.Name = "label2";
            label2.Size = new Size(165, 23);
            label2.TabIndex = 3;
            label2.Text = "Register Student";
            // 
            // StudentFirstName
            // 
            StudentFirstName.BorderStyle = BorderStyle.FixedSingle;
            StudentFirstName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentFirstName.Location = new Point(136, 121);
            StudentFirstName.Name = "StudentFirstName";
            StudentFirstName.PlaceholderText = "Enter firstname";
            StudentFirstName.Size = new Size(361, 32);
            StudentFirstName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 126);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 6;
            label3.Text = "First Name : ";
            // 
            // StudentLastName
            // 
            StudentLastName.BorderStyle = BorderStyle.FixedSingle;
            StudentLastName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentLastName.Location = new Point(646, 121);
            StudentLastName.Name = "StudentLastName";
            StudentLastName.PlaceholderText = "Enter lastname";
            StudentLastName.Size = new Size(355, 32);
            StudentLastName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(527, 126);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 8;
            label4.Text = "Last Name : ";
            // 
            // StudentGender
            // 
            StudentGender.Cursor = Cursors.Hand;
            StudentGender.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentGender.FormattingEnabled = true;
            StudentGender.Items.AddRange(new object[] { "Male", "Female" });
            StudentGender.Location = new Point(136, 186);
            StudentGender.Name = "StudentGender";
            StudentGender.Size = new Size(361, 35);
            StudentGender.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 192);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 11;
            label5.Text = "Gender : ";
            // 
            // StudentClass
            // 
            StudentClass.Cursor = Cursors.Hand;
            StudentClass.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentClass.FormattingEnabled = true;
            StudentClass.Items.AddRange(new object[] { "Male", "Female" });
            StudentClass.Location = new Point(646, 186);
            StudentClass.Name = "StudentClass";
            StudentClass.Size = new Size(355, 35);
            StudentClass.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(530, 192);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 13;
            label6.Text = "Class : ";
            // 
            // btn_update_student
            // 
            btn_update_student.Enabled = false;
            btn_update_student.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update_student.Location = new Point(795, 261);
            btn_update_student.Name = "btn_update_student";
            btn_update_student.Size = new Size(222, 44);
            btn_update_student.TabIndex = 23;
            btn_update_student.Text = "Update";
            btn_update_student.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_update_student.UseVisualStyleBackColor = true;
            btn_update_student.Click += btn_update_student_Click;
            // 
            // btn_del_student
            // 
            btn_del_student.Enabled = false;
            btn_del_student.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_del_student.Location = new Point(542, 261);
            btn_del_student.Name = "btn_del_student";
            btn_del_student.Size = new Size(230, 44);
            btn_del_student.TabIndex = 22;
            btn_del_student.Text = "Delete";
            btn_del_student.UseVisualStyleBackColor = true;
            btn_del_student.Click += btn_del_student_Click;
            // 
            // btn_edit_student
            // 
            btn_edit_student.Enabled = false;
            btn_edit_student.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit_student.Location = new Point(280, 261);
            btn_edit_student.Name = "btn_edit_student";
            btn_edit_student.Size = new Size(230, 44);
            btn_edit_student.TabIndex = 21;
            btn_edit_student.Text = "Edit";
            btn_edit_student.UseVisualStyleBackColor = true;
            btn_edit_student.Click += btn_edit_student_Click;
            // 
            // btn_insert_student
            // 
            btn_insert_student.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_insert_student.Location = new Point(19, 261);
            btn_insert_student.Name = "btn_insert_student";
            btn_insert_student.Size = new Size(230, 44);
            btn_insert_student.TabIndex = 20;
            btn_insert_student.Text = "Create";
            btn_insert_student.UseVisualStyleBackColor = true;
            btn_insert_student.Click += btn_insert_student_Click;
            // 
            // dgv_student
            // 
            dgv_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student.Columns.AddRange(new DataGridViewColumn[] { Id, FullName, Gender, Class, Status });
            dgv_student.Location = new Point(20, 336);
            dgv_student.Name = "dgv_student";
            dgv_student.RowHeadersWidth = 51;
            dgv_student.Size = new Size(997, 298);
            dgv_student.TabIndex = 24;
            dgv_student.CellClick += dgv_student_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 375;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 200;
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.MinimumWidth = 6;
            Class.Name = "Class";
            Class.Width = 120;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 120;
            // 
            // AdminStudentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 646);
            Controls.Add(dgv_student);
            Controls.Add(btn_update_student);
            Controls.Add(btn_del_student);
            Controls.Add(btn_edit_student);
            Controls.Add(btn_insert_student);
            Controls.Add(StudentClass);
            Controls.Add(label6);
            Controls.Add(StudentGender);
            Controls.Add(label5);
            Controls.Add(StudentLastName);
            Controls.Add(label4);
            Controls.Add(StudentFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminStudentPage";
            Text = "AdminStudentPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox StudentFirstName;
        private Label label3;
        private TextBox StudentLastName;
        private Label label4;
        private ComboBox StudentGender;
        private Label label5;
        private ComboBox StudentClass;
        private Label label6;
        private Button btn_update_student;
        private Button btn_del_student;
        private Button btn_edit_student;
        private Button btn_insert_student;
        private DataGridView dgv_student;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn Status;
    }
}