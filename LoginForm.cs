using Microsoft.EntityFrameworkCore;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Database;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Observer.Attendances;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Departments;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Students;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Users;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Utils;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    public partial class LoginForm : Form
    {
        private readonly AppDbContext _context;
        private readonly UserRepository _userRepository;
        private readonly DepartmentRepository _departmentRepository;
        private readonly ClassesRepository _classesRepository;
        private readonly StudentRepository _studentRepository;
        private readonly AttendanceRepository _attendanceRepository;

        public LoginForm(AppDbContext context, UserRepository userRepository, DepartmentRepository departmentRepository, ClassesRepository classesRepository, StudentRepository studentRepository, AttendanceRepository attendanceRepository)
        {

            InitializeComponent();
            this._context = context;
            this._userRepository = userRepository;
            _departmentRepository = departmentRepository;
            _classesRepository = classesRepository;
            _studentRepository = studentRepository;
            _attendanceRepository = attendanceRepository;
          
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string Username = name.Text;
            string Password = password.Text;
            btn_login.Enabled = false;

            try
            {
                var User = await _context.Users.FirstOrDefaultAsync(u => u.Username == Username);

                if (User == null || !PasswordUtils.VerifyPassword(Password, User.Password))
                {
                    MessageBox.Show("Incorrect credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Instance.Log($"Failed login attempt for username: {Username}");
                    return;
                }

                Logger.Instance.Log($"User '{User.Username}' logged in successfully.");

                switch (User.Role)
                {
                    case Role.Admin:
                        AdminDashboard adminDashboard = new AdminDashboard(User, _userRepository, _departmentRepository, _classesRepository, _studentRepository);
                        adminDashboard.Show();
                        this.Hide();
                        break;
                    case Role.Teacher:
                        TeacherDashboardForm teacherDashboard = new TeacherDashboardForm(User,_classesRepository,_studentRepository, _attendanceRepository);
                        teacherDashboard.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Access Denied! Invalid Role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Logger.Instance.Log($"Unauthorized access attempt by {User.Username}");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing your request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Instance.Log($"Login error for {Username}: {ex.Message}");
            }
            finally
            {
                btn_login.Enabled = true;
            }
        }

    }
}
