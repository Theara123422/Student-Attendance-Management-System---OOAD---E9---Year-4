using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Observer.Attendances;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Students;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;
namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    public partial class TeacherDashboardForm : Form
    {
        private readonly User _user;
        private readonly ClassesRepository _classesRepository;
        private readonly StudentRepository _studentRepository;
        private readonly AttendanceRepository _attendanceRepository;

        public TeacherDashboardForm(User user, ClassesRepository classesRepository, StudentRepository studentRepository, AttendanceRepository attendanceRepository)
        {
           
            _studentRepository = studentRepository;
            _classesRepository = classesRepository;
            _attendanceRepository = attendanceRepository;
            _user = user;
            InitializeComponent();
            teacher_username.Text = _user.Username;
            teacher_email.Text = _user.Email;
        }
        private void LoadForm(object Form)
        {
            if (this.ContentTeacher.Controls.Count > 0)
            {
                this.ContentTeacher.Controls.RemoveAt(0);
            }

            Form? f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.ContentTeacher.Controls.Add(f);
            this.ContentTeacher.Tag = f;
            f.Show();

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want Logout?",
                                                    "Confirm Logout",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void teacher_dashboard_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new TeacherClassesPage(_user, _classesRepository));
        }

        private void attendance_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new MarkAttendancePage(_user, _classesRepository,_studentRepository,_attendanceRepository));
        }
    }
}
