namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            Sidebar = new Panel();
            logout_btn = new PictureBox();
            department_btn = new Button();
            class_btn = new Button();
            student_btn = new Button();
            Professor_btn = new Button();
            dashboard_btn = new Button();
            Navbar = new Panel();
            pictureBox2 = new PictureBox();
            email = new Label();
            username = new Label();
            profile = new PictureBox();
            Title = new Label();
            ContentAdmin = new Panel();
            Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout_btn).BeginInit();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profile).BeginInit();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.White;
            Sidebar.Controls.Add(logout_btn);
            Sidebar.Controls.Add(department_btn);
            Sidebar.Controls.Add(class_btn);
            Sidebar.Controls.Add(student_btn);
            Sidebar.Controls.Add(Professor_btn);
            Sidebar.Controls.Add(dashboard_btn);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(4, 70);
            Sidebar.Name = "Sidebar";
            Sidebar.Padding = new Padding(10);
            Sidebar.Size = new Size(248, 646);
            Sidebar.TabIndex = 1;
            // 
            // logout_btn
            // 
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.Image = (Image)resources.GetObject("logout_btn.Image");
            logout_btn.Location = new Point(102, 554);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(40, 32);
            logout_btn.SizeMode = PictureBoxSizeMode.Zoom;
            logout_btn.TabIndex = 6;
            logout_btn.TabStop = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // department_btn
            // 
            department_btn.Cursor = Cursors.Hand;
            department_btn.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            department_btn.FlatAppearance.BorderSize = 0;
            department_btn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            department_btn.Location = new Point(3, 417);
            department_btn.Name = "department_btn";
            department_btn.Size = new Size(242, 52);
            department_btn.TabIndex = 5;
            department_btn.Text = "Department";
            department_btn.UseVisualStyleBackColor = true;
            department_btn.Click += department_btn_Click;
            // 
            // class_btn
            // 
            class_btn.Cursor = Cursors.Hand;
            class_btn.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            class_btn.FlatAppearance.BorderSize = 0;
            class_btn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            class_btn.Location = new Point(3, 316);
            class_btn.Name = "class_btn";
            class_btn.Size = new Size(242, 52);
            class_btn.TabIndex = 3;
            class_btn.Text = "Classes";
            class_btn.UseVisualStyleBackColor = true;
            class_btn.Click += class_btn_Click;
            // 
            // student_btn
            // 
            student_btn.Cursor = Cursors.Hand;
            student_btn.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            student_btn.FlatAppearance.BorderSize = 0;
            student_btn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_btn.Location = new Point(3, 221);
            student_btn.Name = "student_btn";
            student_btn.Size = new Size(242, 52);
            student_btn.TabIndex = 2;
            student_btn.Text = "Students";
            student_btn.UseVisualStyleBackColor = true;
            student_btn.Click += student_btn_Click;
            // 
            // Professor_btn
            // 
            Professor_btn.Cursor = Cursors.Hand;
            Professor_btn.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            Professor_btn.FlatAppearance.BorderSize = 0;
            Professor_btn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Professor_btn.Location = new Point(3, 120);
            Professor_btn.Name = "Professor_btn";
            Professor_btn.Size = new Size(242, 52);
            Professor_btn.TabIndex = 1;
            Professor_btn.Text = "Professors";
            Professor_btn.UseVisualStyleBackColor = true;
            Professor_btn.Click += Professor_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.Location = new Point(3, 29);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(242, 52);
            dashboard_btn.TabIndex = 0;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = true;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // Navbar
            // 
            Navbar.BackColor = Color.DodgerBlue;
            Navbar.Controls.Add(pictureBox2);
            Navbar.Controls.Add(email);
            Navbar.Controls.Add(username);
            Navbar.Controls.Add(profile);
            Navbar.Controls.Add(Title);
            Navbar.Dock = DockStyle.Top;
            Navbar.Location = new Point(4, 4);
            Navbar.Margin = new Padding(3, 3, 10, 3);
            Navbar.Name = "Navbar";
            Navbar.Padding = new Padding(0, 0, 0, 10);
            Navbar.Size = new Size(1292, 66);
            Navbar.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = SystemColors.Control;
            email.Location = new Point(1138, 37);
            email.Name = "email";
            email.Padding = new Padding(0, 0, 0, 5);
            email.Size = new Size(151, 21);
            email.TabIndex = 3;
            email.Text = "theara123@gmail.com";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = SystemColors.Control;
            username.Location = new Point(1137, 11);
            username.Name = "username";
            username.Padding = new Padding(0, 0, 0, 5);
            username.Size = new Size(104, 26);
            username.TabIndex = 2;
            username.Text = "Pen Theara";
            // 
            // profile
            // 
            profile.Image = (Image)resources.GetObject("profile.Image");
            profile.Location = new Point(1077, 10);
            profile.Name = "profile";
            profile.Size = new Size(51, 48);
            profile.SizeMode = PictureBoxSizeMode.Zoom;
            profile.TabIndex = 1;
            profile.TabStop = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.Control;
            Title.Location = new Point(69, 18);
            Title.Name = "Title";
            Title.Padding = new Padding(0, 0, 0, 5);
            Title.Size = new Size(486, 32);
            Title.TabIndex = 0;
            Title.Text = "Student Attendance Management System ";
            // 
            // ContentAdmin
            // 
            ContentAdmin.BackColor = Color.White;
            ContentAdmin.Dock = DockStyle.Right;
            ContentAdmin.Location = new Point(260, 70);
            ContentAdmin.Margin = new Padding(5);
            ContentAdmin.Name = "ContentAdmin";
            ContentAdmin.Padding = new Padding(4);
            ContentAdmin.Size = new Size(1036, 646);
            ContentAdmin.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1300, 720);
            Controls.Add(ContentAdmin);
            Controls.Add(Sidebar);
            Controls.Add(Navbar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AdminDashboard";
            Padding = new Padding(4);
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logout_btn).EndInit();
            Navbar.ResumeLayout(false);
            Navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)profile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Sidebar;
        private Panel Navbar;
        private Panel ContentAdmin;
        private Label Title;
        private PictureBox profile;
        private Label username;
        private Label email;
        private Button dashboard_btn;
        private Button student_btn;
        private Button Professor_btn;
        private Button class_btn;
        private PictureBox logout_btn;
        private Button department_btn;
        private PictureBox pictureBox2;
    }
}