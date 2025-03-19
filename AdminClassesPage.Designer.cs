namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class AdminClassesPage
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
            username = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ClassLabel = new TextBox();
            label5 = new Label();
            ClassDepartment = new ComboBox();
            ClassYear = new ComboBox();
            label6 = new Label();
            ClassSection = new ComboBox();
            label7 = new Label();
            btn_update_class = new Button();
            btn_del_class = new Button();
            btn_edit_class = new Button();
            btn_insert_class = new Button();
            dgv_classes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Labels = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            FacultyName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Section = new DataGridViewTextBoxColumn();
            Students = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_classes).BeginInit();
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
            panel1.Size = new Size(1036, 50);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(188, 23);
            label2.TabIndex = 0;
            label2.Text = "Admin Class Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(13, 69);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 2;
            label1.Text = "Manage Classes";
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(137, 113);
            username.Name = "username";
            username.PlaceholderText = "Enter class label";
            username.Size = new Size(317, 32);
            username.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 118);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 6;
            label3.Text = "Name  : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 118);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 6;
            label4.Text = "Name  : ";
            // 
            // ClassLabel
            // 
            ClassLabel.BorderStyle = BorderStyle.FixedSingle;
            ClassLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClassLabel.Location = new Point(137, 113);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.PlaceholderText = "Enter class label";
            ClassLabel.Size = new Size(343, 32);
            ClassLabel.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(498, 118);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 8;
            label5.Text = "Department  : ";
            // 
            // ClassDepartment
            // 
            ClassDepartment.Cursor = Cursors.Hand;
            ClassDepartment.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClassDepartment.FormattingEnabled = true;
            ClassDepartment.Location = new Point(631, 112);
            ClassDepartment.Name = "ClassDepartment";
            ClassDepartment.Size = new Size(382, 35);
            ClassDepartment.TabIndex = 10;
            // 
            // ClassYear
            // 
            ClassYear.Cursor = Cursors.Hand;
            ClassYear.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClassYear.FormattingEnabled = true;
            ClassYear.Items.AddRange(new object[] { "Freshman", "Sophomore", "Junior", "Senior" });
            ClassYear.Location = new Point(137, 180);
            ClassYear.Name = "ClassYear";
            ClassYear.Size = new Size(343, 35);
            ClassYear.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 186);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 11;
            label6.Text = "Year  : ";
            // 
            // ClassSection
            // 
            ClassSection.Cursor = Cursors.Hand;
            ClassSection.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClassSection.FormattingEnabled = true;
            ClassSection.Items.AddRange(new object[] { "Morning", "Afternoon", "Evening" });
            ClassSection.Location = new Point(631, 180);
            ClassSection.Name = "ClassSection";
            ClassSection.Size = new Size(382, 35);
            ClassSection.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(498, 186);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 13;
            label7.Text = "Section  : ";
            // 
            // btn_update_class
            // 
            btn_update_class.Enabled = false;
            btn_update_class.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update_class.Location = new Point(791, 256);
            btn_update_class.Name = "btn_update_class";
            btn_update_class.Size = new Size(222, 44);
            btn_update_class.TabIndex = 19;
            btn_update_class.Text = "Update";
            btn_update_class.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_update_class.UseVisualStyleBackColor = true;
            btn_update_class.Click += btn_update_class_Click;
            // 
            // btn_del_class
            // 
            btn_del_class.Enabled = false;
            btn_del_class.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_del_class.Location = new Point(538, 256);
            btn_del_class.Name = "btn_del_class";
            btn_del_class.Size = new Size(230, 44);
            btn_del_class.TabIndex = 18;
            btn_del_class.Text = "Delete";
            btn_del_class.UseVisualStyleBackColor = true;
            btn_del_class.Click += btn_del_class_Click;
            // 
            // btn_edit_class
            // 
            btn_edit_class.Enabled = false;
            btn_edit_class.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit_class.Location = new Point(276, 256);
            btn_edit_class.Name = "btn_edit_class";
            btn_edit_class.Size = new Size(230, 44);
            btn_edit_class.TabIndex = 17;
            btn_edit_class.Text = "Edit";
            btn_edit_class.UseVisualStyleBackColor = true;
            btn_edit_class.Click += btn_edit_class_Click;
            // 
            // btn_insert_class
            // 
            btn_insert_class.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_insert_class.Location = new Point(15, 256);
            btn_insert_class.Name = "btn_insert_class";
            btn_insert_class.Size = new Size(230, 44);
            btn_insert_class.TabIndex = 16;
            btn_insert_class.Text = "Create";
            btn_insert_class.UseVisualStyleBackColor = true;
            btn_insert_class.Click += btn_insert_class_Click;
            // 
            // dgv_classes
            // 
            dgv_classes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_classes.Columns.AddRange(new DataGridViewColumn[] { Id, Labels, Department, FacultyName, Year, Section, Students });
            dgv_classes.Location = new Point(13, 333);
            dgv_classes.Name = "dgv_classes";
            dgv_classes.RowHeadersWidth = 51;
            dgv_classes.Size = new Size(1000, 301);
            dgv_classes.TabIndex = 20;
            dgv_classes.CellClick += dgv_classes_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // Labels
            // 
            Labels.HeaderText = "Label";
            Labels.MinimumWidth = 6;
            Labels.Name = "Labels";
            Labels.Width = 75;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            Department.Width = 285;
            // 
            // FacultyName
            // 
            FacultyName.HeaderText = "Faculty";
            FacultyName.MinimumWidth = 6;
            FacultyName.Name = "FacultyName";
            FacultyName.Width = 285;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.Width = 50;
            // 
            // Section
            // 
            Section.HeaderText = "Section";
            Section.MinimumWidth = 6;
            Section.Name = "Section";
            Section.Width = 125;
            // 
            // Students
            // 
            Students.HeaderText = "Students";
            Students.MinimumWidth = 6;
            Students.Name = "Students";
            Students.Width = 125;
            // 
            // AdminClassesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 646);
            Controls.Add(dgv_classes);
            Controls.Add(btn_update_class);
            Controls.Add(btn_del_class);
            Controls.Add(btn_edit_class);
            Controls.Add(btn_insert_class);
            Controls.Add(ClassSection);
            Controls.Add(label7);
            Controls.Add(ClassYear);
            Controls.Add(label6);
            Controls.Add(ClassDepartment);
            Controls.Add(label5);
            Controls.Add(ClassLabel);
            Controls.Add(username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminClassesPage";
            Text = "AdminClassesPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_classes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox username;
        private Label label3;
        private Label label4;
        private TextBox ClassLabel;
        private Label label5;
        private ComboBox ClassDepartment;
        private ComboBox ClassYear;
        private Label label6;
        private ComboBox ClassSection;
        private Label label7;
        private Button btn_update_class;
        private Button btn_del_class;
        private Button btn_edit_class;
        private Button btn_insert_class;
        private DataGridView dgv_classes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Labels;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn FacultyName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn Students;
    }
}