﻿using Student_Attendance_Management_System___OOAD___E9___Year_4.Database;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Departments;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Users;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4;

public partial class AdminDashboard : Form
{
    private User _user;
    private readonly UserRepository _userRepository;
    private readonly DepartmentRepository _departmentRepository;
    private readonly ClassesRepository _classesRepository;
    public AdminDashboard(User user, UserRepository userRepository, DepartmentRepository departmentRepository, ClassesRepository classesRepository)
    {
        _user = user;
        _userRepository = userRepository;
        _departmentRepository = departmentRepository;
        _classesRepository = classesRepository;
        InitializeComponent();
        username.Text = user.FullName;
        email.Text = user.Email;
    }

    private void LoadForm(object Form)
    {
        if (this.ContentAdmin.Controls.Count > 0)
        {
            this.ContentAdmin.Controls.RemoveAt(0);
        }

        Form? f = Form as Form;
        f.TopLevel = false;
        f.Dock = DockStyle.Fill;
        this.ContentAdmin.Controls.Add(f);
        this.ContentAdmin.Tag = f;
        f.Show();

    }

    private void dashboard_btn_Click(object sender, EventArgs e)
    {
        LoadForm(new AdminDashboardPage());
    }

    private void Professor_btn_Click(object sender, EventArgs e)
    {
        LoadForm(new AdminProfessorPage(_userRepository));
    }

    private void class_btn_Click(object sender, EventArgs e)
    {
        LoadForm(new AdminClassesPage(_classesRepository, _userRepository, _departmentRepository, _user));
    }

    private void student_btn_Click(object sender, EventArgs e)
    {
        LoadForm(new AdminStudentPage());
    }

    private void department_btn_Click(object sender, EventArgs e)
    {
        LoadForm(new AdminDepartmentPage(_departmentRepository));
    }

    private void AdminDashboard_Load(object sender, EventArgs e)
    {
        LoadForm(new AdminDashboardPage());
    }

    private void logout_btn_Click(object sender, EventArgs e)
    {
        var confirmResult = MessageBox.Show("Are you sure you want Logout?",
                                                    "Confirm Logout",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
        if(confirmResult == DialogResult.Yes)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
