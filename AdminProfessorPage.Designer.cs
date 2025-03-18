namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class AdminProfessorPage
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
            dgvAdminProfessor = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            full_name = new DataGridViewTextBoxColumn();
            user_name = new DataGridViewTextBoxColumn();
            edu = new DataGridViewTextBoxColumn();
            _status = new DataGridViewTextBoxColumn();
            label3 = new Label();
            username = new TextBox();
            fullname = new TextBox();
            label4 = new Label();
            email = new TextBox();
            label5 = new Label();
            password = new TextBox();
            label6 = new Label();
            btn_insert_prof = new Button();
            btn_edit_prof = new Button();
            btn_del_prof = new Button();
            btn_update_prof = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminProfessor).BeginInit();
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
            label2.Size = new Size(222, 23);
            label2.TabIndex = 0;
            label2.Text = "Admin Professor Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(13, 71);
            label1.Name = "label1";
            label1.Size = new Size(193, 23);
            label1.TabIndex = 2;
            label1.Text = "Manage Professors";
            // 
            // dgvAdminProfessor
            // 
            dgvAdminProfessor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminProfessor.Columns.AddRange(new DataGridViewColumn[] { Id, full_name, user_name, edu, _status });
            dgvAdminProfessor.Location = new Point(12, 308);
            dgvAdminProfessor.Name = "dgvAdminProfessor";
            dgvAdminProfessor.RowHeadersWidth = 51;
            dgvAdminProfessor.Size = new Size(1012, 326);
            dgvAdminProfessor.TabIndex = 3;
            dgvAdminProfessor.CellClick += dgvAdminProfessor_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // full_name
            // 
            full_name.HeaderText = "Full Name";
            full_name.MinimumWidth = 6;
            full_name.Name = "full_name";
            full_name.Width = 200;
            // 
            // user_name
            // 
            user_name.HeaderText = "Username";
            user_name.MinimumWidth = 6;
            user_name.Name = "user_name";
            user_name.Width = 200;
            // 
            // edu
            // 
            edu.HeaderText = "Edu. Background";
            edu.MinimumWidth = 6;
            edu.Name = "edu";
            edu.Width = 380;
            // 
            // _status
            // 
            _status.HeaderText = "Status";
            _status.MinimumWidth = 6;
            _status.Name = "_status";
            _status.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 123);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 4;
            label3.Text = "Username : ";
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(132, 118);
            username.Name = "username";
            username.PlaceholderText = "Enter username";
            username.Size = new Size(317, 32);
            username.TabIndex = 5;
            // 
            // fullname
            // 
            fullname.BorderStyle = BorderStyle.FixedSingle;
            fullname.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullname.Location = new Point(588, 118);
            fullname.Name = "fullname";
            fullname.PlaceholderText = "Enter full name";
            fullname.Size = new Size(436, 32);
            fullname.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(469, 123);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 6;
            label4.Text = "Full Name : ";
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(132, 186);
            email.Name = "email";
            email.PlaceholderText = "Enter email";
            email.Size = new Size(317, 32);
            email.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 191);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 8;
            label5.Text = "Email : ";
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(588, 187);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Enter password";
            password.Size = new Size(436, 32);
            password.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(469, 192);
            label6.Name = "label6";
            label6.Size = new Size(105, 21);
            label6.TabIndex = 10;
            label6.Text = "Password : ";
            // 
            // btn_insert_prof
            // 
            btn_insert_prof.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_insert_prof.Location = new Point(13, 242);
            btn_insert_prof.Name = "btn_insert_prof";
            btn_insert_prof.Size = new Size(230, 44);
            btn_insert_prof.TabIndex = 12;
            btn_insert_prof.Text = "Create";
            btn_insert_prof.UseVisualStyleBackColor = true;
            btn_insert_prof.Click += btn_insert_prof_Click;
            // 
            // btn_edit_prof
            // 
            btn_edit_prof.Enabled = false;
            btn_edit_prof.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit_prof.Location = new Point(274, 242);
            btn_edit_prof.Name = "btn_edit_prof";
            btn_edit_prof.Size = new Size(230, 44);
            btn_edit_prof.TabIndex = 13;
            btn_edit_prof.Text = "Edit";
            btn_edit_prof.UseVisualStyleBackColor = true;
            btn_edit_prof.Click += btn_edit_prof_Click;
            // 
            // btn_del_prof
            // 
            btn_del_prof.Enabled = false;
            btn_del_prof.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_del_prof.Location = new Point(536, 242);
            btn_del_prof.Name = "btn_del_prof";
            btn_del_prof.Size = new Size(230, 44);
            btn_del_prof.TabIndex = 14;
            btn_del_prof.Text = "Delete";
            btn_del_prof.UseVisualStyleBackColor = true;
            btn_del_prof.Click += btn_del_prof_Click;
            // 
            // btn_update_prof
            // 
            btn_update_prof.Enabled = false;
            btn_update_prof.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update_prof.Location = new Point(789, 242);
            btn_update_prof.Name = "btn_update_prof";
            btn_update_prof.Size = new Size(230, 44);
            btn_update_prof.TabIndex = 15;
            btn_update_prof.Text = "Update";
            btn_update_prof.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_update_prof.UseVisualStyleBackColor = true;
            btn_update_prof.Click += btn_update_prof_Click;
            // 
            // AdminProfessorPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1036, 646);
            Controls.Add(btn_update_prof);
            Controls.Add(btn_del_prof);
            Controls.Add(btn_edit_prof);
            Controls.Add(btn_insert_prof);
            Controls.Add(password);
            Controls.Add(label6);
            Controls.Add(email);
            Controls.Add(label5);
            Controls.Add(fullname);
            Controls.Add(label4);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(dgvAdminProfessor);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminProfessorPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminProfessor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private DataGridView dgvAdminProfessor;
        private Label label3;
        private TextBox username;
        private TextBox fullname;
        private Label label4;
        private TextBox email;
        private Label label5;
        private TextBox password;
        private Label label6;
        private Button btn_insert_prof;
        private Button btn_edit_prof;
        private Button btn_del_prof;
        private Button btn_update_prof;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn full_name;
        private DataGridViewTextBoxColumn user_name;
        private DataGridViewTextBoxColumn edu;
        private DataGridViewTextBoxColumn _status;
    }
}