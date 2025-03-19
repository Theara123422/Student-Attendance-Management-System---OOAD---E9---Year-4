using Microsoft.EntityFrameworkCore;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Database;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Departments;
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

        public LoginForm(AppDbContext context, UserRepository userRepository, DepartmentRepository departmentRepository, ClassesRepository classesRepository)
        {
            InitializeComponent();
            this._context = context;
            this._userRepository = userRepository;
            _departmentRepository = departmentRepository;
            _classesRepository = classesRepository;
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string Username = name.Text;
            string Password = password.Text;

            // Disable the login button to prevent multiple clicks
            btn_login.Enabled = false;

            try
            {
              
                var User = await _context.Users.FirstOrDefaultAsync(u => u.Username == Username);


                if (User == null || PasswordUtils.VerifyPassword(Password, User.Password))
                {
                    MessageBox.Show("Incorrect credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (User.Role)
                {
                    case Role.Admin:
                        AdminDashboard adminDashboard = new AdminDashboard(User,_userRepository,_departmentRepository, _classesRepository);
                        adminDashboard.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Access Denied! Invalid Role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing your request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_login.Enabled = true;
            }
        }
    }
}
