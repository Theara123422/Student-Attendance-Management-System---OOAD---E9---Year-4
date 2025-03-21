namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    partial class BtnMarkAttendanceForm
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
            MarkFor = new Label();
            btn_present = new Button();
            btn_absent = new Button();
            btn_permission = new Button();
            SuspendLayout();
            // 
            // MarkFor
            // 
            MarkFor.AutoSize = true;
            MarkFor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MarkFor.ForeColor = Color.DodgerBlue;
            MarkFor.Location = new Point(12, 45);
            MarkFor.Name = "MarkFor";
            MarkFor.Size = new Size(312, 23);
            MarkFor.TabIndex = 4;
            MarkFor.Text = "Mark Attendane for Pen Theara";
            // 
            // btn_present
            // 
            btn_present.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_present.Location = new Point(12, 120);
            btn_present.Name = "btn_present";
            btn_present.Size = new Size(230, 44);
            btn_present.TabIndex = 13;
            btn_present.Text = "Present";
            btn_present.UseVisualStyleBackColor = true;
            btn_present.Click += btn_present_Click;
            // 
            // btn_absent
            // 
            btn_absent.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_absent.Location = new Point(257, 120);
            btn_absent.Name = "btn_absent";
            btn_absent.Size = new Size(230, 44);
            btn_absent.TabIndex = 14;
            btn_absent.Text = "Absent";
            btn_absent.UseVisualStyleBackColor = true;
            btn_absent.Click += btn_absent_Click;
            // 
            // btn_permission
            // 
            btn_permission.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_permission.Location = new Point(505, 120);
            btn_permission.Name = "btn_permission";
            btn_permission.Size = new Size(230, 44);
            btn_permission.TabIndex = 15;
            btn_permission.Text = "Permission";
            btn_permission.UseVisualStyleBackColor = true;
            btn_permission.Click += btn_permission_Click;
            // 
            // BtnMarkAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 267);
            Controls.Add(btn_permission);
            Controls.Add(btn_absent);
            Controls.Add(btn_present);
            Controls.Add(MarkFor);
            Name = "BtnMarkAttendanceForm";
            Text = "BtnMarkAttendanceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MarkFor;
        private Button btn_present;
        private Button btn_absent;
        private Button btn_permission;
    }
}