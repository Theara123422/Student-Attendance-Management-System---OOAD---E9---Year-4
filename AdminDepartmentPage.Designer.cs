namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class AdminDepartmentPage
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
            DepartmentName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Faculty = new ComboBox();
            btn_update_depart = new Button();
            btn_del_depart = new Button();
            btn_edit_depart = new Button();
            btn_insert_dep = new Button();
            dgv_depart = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Names = new DataGridViewTextBoxColumn();
            FacultyName = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_depart).BeginInit();
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
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(257, 23);
            label2.TabIndex = 0;
            label2.Text = "Admin Department Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(14, 72);
            label1.Name = "label1";
            label1.Size = new Size(213, 23);
            label1.TabIndex = 3;
            label1.Text = "Manage Department";
            // 
            // DepartmentName
            // 
            DepartmentName.BorderStyle = BorderStyle.FixedSingle;
            DepartmentName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepartmentName.Location = new Point(136, 130);
            DepartmentName.Name = "DepartmentName";
            DepartmentName.PlaceholderText = "Enter department name :";
            DepartmentName.Size = new Size(343, 32);
            DepartmentName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 135);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 6;
            label3.Text = "Name : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(496, 135);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 8;
            label4.Text = "Faculty : ";
            // 
            // Faculty
            // 
            Faculty.Cursor = Cursors.Hand;
            Faculty.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Faculty.FormattingEnabled = true;
            Faculty.Items.AddRange(new object[] { "Faculty of Scicence", "Faculty of Engineering", "Faculty of Development Study", "Faculty of Education", "Institute of Foreign Language" });
            Faculty.Location = new Point(617, 128);
            Faculty.Name = "Faculty";
            Faculty.Size = new Size(405, 31);
            Faculty.TabIndex = 9;
            // 
            // btn_update_depart
            // 
            btn_update_depart.Enabled = false;
            btn_update_depart.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update_depart.Location = new Point(792, 208);
            btn_update_depart.Name = "btn_update_depart";
            btn_update_depart.Size = new Size(230, 44);
            btn_update_depart.TabIndex = 19;
            btn_update_depart.Text = "Update";
            btn_update_depart.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_update_depart.UseVisualStyleBackColor = true;
            btn_update_depart.Click += btn_update_depart_Click;
            // 
            // btn_del_depart
            // 
            btn_del_depart.Enabled = false;
            btn_del_depart.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_del_depart.Location = new Point(539, 208);
            btn_del_depart.Name = "btn_del_depart";
            btn_del_depart.Size = new Size(230, 44);
            btn_del_depart.TabIndex = 18;
            btn_del_depart.Text = "Delete";
            btn_del_depart.UseVisualStyleBackColor = true;
            btn_del_depart.Click += btn_del_depart_Click;
            // 
            // btn_edit_depart
            // 
            btn_edit_depart.Enabled = false;
            btn_edit_depart.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit_depart.Location = new Point(277, 208);
            btn_edit_depart.Name = "btn_edit_depart";
            btn_edit_depart.Size = new Size(230, 44);
            btn_edit_depart.TabIndex = 17;
            btn_edit_depart.Text = "Edit";
            btn_edit_depart.UseVisualStyleBackColor = true;
            btn_edit_depart.Click += btn_edit_depart_Click;
            // 
            // btn_insert_dep
            // 
            btn_insert_dep.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_insert_dep.Location = new Point(16, 208);
            btn_insert_dep.Name = "btn_insert_dep";
            btn_insert_dep.Size = new Size(230, 44);
            btn_insert_dep.TabIndex = 16;
            btn_insert_dep.Text = "Create";
            btn_insert_dep.UseVisualStyleBackColor = true;
            btn_insert_dep.Click += btn_insert_prof_Click;
            // 
            // dgv_depart
            // 
            dgv_depart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_depart.Columns.AddRange(new DataGridViewColumn[] { Id, Names, FacultyName });
            dgv_depart.Location = new Point(15, 286);
            dgv_depart.Name = "dgv_depart";
            dgv_depart.RowHeadersWidth = 51;
            dgv_depart.Size = new Size(1006, 348);
            dgv_depart.TabIndex = 20;
            dgv_depart.CellClick += dgv_depart_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Names
            // 
            Names.HeaderText = "Name";
            Names.MinimumWidth = 6;
            Names.Name = "Names";
            Names.Width = 400;
            // 
            // FacultyName
            // 
            FacultyName.HeaderText = "Faculty";
            FacultyName.MinimumWidth = 6;
            FacultyName.Name = "FacultyName";
            FacultyName.Width = 425;
            // 
            // AdminDepartmentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 646);
            Controls.Add(dgv_depart);
            Controls.Add(btn_update_depart);
            Controls.Add(btn_del_depart);
            Controls.Add(btn_edit_depart);
            Controls.Add(btn_insert_dep);
            Controls.Add(Faculty);
            Controls.Add(label4);
            Controls.Add(DepartmentName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDepartmentPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_depart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox DepartmentName;
        private Label label3;
        private Label label4;
        private ComboBox Faculty;
        private Button btn_update_depart;
        private Button btn_del_depart;
        private Button btn_edit_depart;
        private Button btn_insert_dep;
        private DataGridView dgv_depart;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Names;
        private DataGridViewTextBoxColumn FacultyName;
    }
}