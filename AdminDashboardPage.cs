using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    public partial class AdminDashboardPage : Form
    {
        private readonly ClassesRepository _classRepository;
        public AdminDashboardPage(ClassesRepository classesRepository)
        {
            _classRepository = classesRepository;
            InitializeComponent();
        }

        private void AdminDashboardPage_Load(object sender, EventArgs e)
        {
            List<StudentClassDepartmentInfo> activeClasses = _classRepository.GetClassDepartmentUserStudentCount();

            dgvAdminDashboard.Rows.Clear();

            foreach (var activeClass in activeClasses)
            {
                dgvAdminDashboard.Rows.Add(activeClass.ClassId,activeClass.ClassName, activeClass.DepartmentName, activeClass.ProfessorName, activeClass.TotalStudent, "Active");
            }
        }
    }
}
