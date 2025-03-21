namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class TeacherDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboardForm));
            Navbar = new Panel();
            pictureBox2 = new PictureBox();
            teacher_email = new Label();
            teacher_username = new Label();
            profile = new PictureBox();
            Title = new Label();
            Sidebar = new Panel();
            attendance_btn = new Button();
            teacher_dashboard_btn = new Button();
            ContentTeacher = new Panel();
            logout_btn = new PictureBox();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profile).BeginInit();
            Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout_btn).BeginInit();
            SuspendLayout();
            // 
            // Navbar
            // 
            Navbar.BackColor = Color.DodgerBlue;
            Navbar.Controls.Add(pictureBox2);
            Navbar.Controls.Add(teacher_email);
            Navbar.Controls.Add(teacher_username);
            Navbar.Controls.Add(profile);
            Navbar.Controls.Add(Title);
            Navbar.Dock = DockStyle.Top;
            Navbar.Location = new Point(0, 0);
            Navbar.Margin = new Padding(3, 3, 10, 3);
            Navbar.Name = "Navbar";
            Navbar.Padding = new Padding(0, 0, 0, 10);
            Navbar.Size = new Size(1300, 66);
            Navbar.TabIndex = 1;
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
            // teacher_email
            // 
            teacher_email.AutoSize = true;
            teacher_email.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacher_email.ForeColor = SystemColors.Control;
            teacher_email.Location = new Point(1120, 37);
            teacher_email.Name = "teacher_email";
            teacher_email.Padding = new Padding(0, 0, 0, 5);
            teacher_email.Size = new Size(151, 21);
            teacher_email.TabIndex = 3;
            teacher_email.Text = "theara123@gmail.com";
            // 
            // teacher_username
            // 
            teacher_username.AutoSize = true;
            teacher_username.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teacher_username.ForeColor = SystemColors.Control;
            teacher_username.Location = new Point(1117, 11);
            teacher_username.Name = "teacher_username";
            teacher_username.Padding = new Padding(0, 0, 0, 5);
            teacher_username.Size = new Size(104, 26);
            teacher_username.TabIndex = 2;
            teacher_username.Text = "Pen Theara";
            // 
            // profile
            // 
            profile.Image = (Image)resources.GetObject("profile.Image");
            profile.Location = new Point(1064, 10);
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
            // Sidebar
            // 
            Sidebar.BackColor = Color.White;
            Sidebar.Controls.Add(logout_btn);
            Sidebar.Controls.Add(attendance_btn);
            Sidebar.Controls.Add(teacher_dashboard_btn);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 66);
            Sidebar.Name = "Sidebar";
            Sidebar.Padding = new Padding(10);
            Sidebar.Size = new Size(248, 654);
            Sidebar.TabIndex = 2;
            // 
            // attendance_btn
            // 
            attendance_btn.Cursor = Cursors.Hand;
            attendance_btn.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            attendance_btn.FlatAppearance.BorderSize = 0;
            attendance_btn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendance_btn.Location = new Point(3, 120);
            attendance_btn.Name = "attendance_btn";
            attendance_btn.Size = new Size(242, 52);
            attendance_btn.TabIndex = 1;
            attendance_btn.Text = "Attendance";
            attendance_btn.UseVisualStyleBackColor = true;
            attendance_btn.Click += attendance_btn_Click;
            // 
            // teacher_dashboard_btn
            // 
            teacher_dashboard_btn.Cursor = Cursors.Hand;
            teacher_dashboard_btn.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            teacher_dashboard_btn.FlatAppearance.BorderSize = 0;
            teacher_dashboard_btn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teacher_dashboard_btn.Location = new Point(3, 29);
            teacher_dashboard_btn.Name = "teacher_dashboard_btn";
            teacher_dashboard_btn.Size = new Size(242, 52);
            teacher_dashboard_btn.TabIndex = 0;
            teacher_dashboard_btn.Text = "Dashboard";
            teacher_dashboard_btn.UseVisualStyleBackColor = true;
            teacher_dashboard_btn.Click += teacher_dashboard_btn_Click;
            // 
            // ContentTeacher
            // 
            ContentTeacher.BackColor = Color.White;
            ContentTeacher.Dock = DockStyle.Right;
            ContentTeacher.Location = new Point(264, 66);
            ContentTeacher.Margin = new Padding(5);
            ContentTeacher.Name = "ContentTeacher";
            ContentTeacher.Padding = new Padding(4);
            ContentTeacher.Size = new Size(1036, 654);
            ContentTeacher.TabIndex = 3;
            // 
            // logout_btn
            // 
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.Image = (Image)resources.GetObject("logout_btn.Image");
            logout_btn.Location = new Point(99, 228);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(40, 32);
            logout_btn.SizeMode = PictureBoxSizeMode.Zoom;
            logout_btn.TabIndex = 6;
            logout_btn.TabStop = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // TeacherDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(ContentTeacher);
            Controls.Add(Sidebar);
            Controls.Add(Navbar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TeacherDashboardForm";
            Text = "Teacher Dashboard";
            Navbar.ResumeLayout(false);
            Navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)profile).EndInit();
            Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logout_btn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Navbar;
        private PictureBox pictureBox2;
        private Label teacher_email;
        private Label teacher_username;
        private PictureBox profile;
        private Label Title;
        private Panel Sidebar;
        private Button attendance_btn;
        private Button teacher_dashboard_btn;
        private Panel ContentTeacher;
        private PictureBox logout_btn;
    }
}