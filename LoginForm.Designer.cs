namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btn_login = new Button();
            linkLabel1 = new LinkLabel();
            remember = new CheckBox();
            name = new TextBox();
            password = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 720);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(819, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn_login);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(remember);
            panel2.Controls.Add(name);
            panel2.Controls.Add(password);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(825, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 720);
            panel2.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DeepSkyBlue;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.Font = new Font("Battambang", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(80, 474);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(327, 47);
            btn_login.TabIndex = 9;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(254, 399);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(143, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password ?";
            // 
            // remember
            // 
            remember.AutoSize = true;
            remember.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remember.Location = new Point(82, 398);
            remember.Name = "remember";
            remember.Size = new Size(140, 24);
            remember.TabIndex = 7;
            remember.Text = "Remember Me";
            remember.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Cursor = Cursors.IBeam;
            name.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(115, 224);
            name.Name = "name";
            name.PlaceholderText = "Enter Username";
            name.Size = new Size(282, 38);
            name.TabIndex = 6;
            name.UseWaitCursor = true;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(115, 310);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Enter Password";
            password.Size = new Size(282, 38);
            password.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(70, 316);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(69, 228);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(103, 133);
            label1.Name = "label1";
            label1.Size = new Size(251, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back...!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1300, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private RichTextBox username;
        private PictureBox pictureBox3;
        private TextBox password;
        private TextBox name;
        private LinkLabel linkLabel1;
        private CheckBox remember;
        private Button btn_login;
    }
}
