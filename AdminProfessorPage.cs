using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Users;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    public partial class AdminProfessorPage : Form
    {
        private readonly UserRepository _userRepository;
        private int SelectedUserIdForAction = -1;

        public AdminProfessorPage(UserRepository userRepository)
        {
            _userRepository = userRepository;
            InitializeComponent();
            LoadUserData();
        }

        private void btn_insert_prof_Click(object sender, EventArgs e)
        {
            btn_insert_prof.Enabled = false;

            string Username = username.Text;
            string FullName = fullname.Text;
            string Email = email.Text;
            string Password = password.Text;

            if (string.IsNullOrWhiteSpace(Username) ||
                string.IsNullOrWhiteSpace(FullName) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_insert_prof.Enabled = true;
                return;
            }

            if (_userRepository.IsUsernameTaken(Username))
            {
                MessageBox.Show("Username already exists. Please choose another.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_insert_prof.Enabled = true;
                return;
            }

            User user = new User
            {
                Username = Username,
                FullName = FullName,
                Email = Email,
                Password = Password,
                Role = Utils.Role.Teacher,
                CreatedAt = DateTime.UtcNow,
                EducationalBackground = "Computer Science",
                Status = Utils.TeacherStatus.Active
            };

            _userRepository.AddUser(user);
            username.Text = "";
            email.Text = "";
            fullname.Text = "";
            password.Text = "";
            btn_insert_prof.Enabled = true;
            LoadUserData();
        }

        private void LoadUserData()
        {
            var users = _userRepository.GetAllUsers();

            dgvAdminProfessor.Rows.Clear();

            foreach (var user in users)
            {
                dgvAdminProfessor.Rows.Add(
                        user.Id,
                        user.FullName,
                        user.Username,
                        user.EducationalBackground,
                        user.Status == 0 ? "Active" : "Retired"
                    );
            }
        }

        private void dgvAdminProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_del_prof.Enabled = true;
                btn_edit_prof.Enabled = true;

                int selectedUserId = Convert.ToInt32(dgvAdminProfessor.Rows[e.RowIndex].Cells["Id"].Value);

                SelectedUserIdForAction = selectedUserId;
            }
        }

        private void btn_edit_prof_Click(object sender, EventArgs e)
        {
            var selectedUser = _userRepository.GetAllUsers().FirstOrDefault(u => u.Id == SelectedUserIdForAction);

            if (selectedUser != null)
            {
                username.Text = selectedUser.Username;
                fullname.Text = selectedUser.FullName;
                email.Text = selectedUser.Email;
                password.Text = selectedUser.Password;

                btn_update_prof.Enabled = true;
            }
        }

        private void btn_del_prof_Click(object sender, EventArgs e)
        {
            var selectedUser = _userRepository.GetAllUsers()
                                      .FirstOrDefault(u => u.Id == SelectedUserIdForAction);

            if (selectedUser != null)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this user?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Call the delete method in the repository
                    _userRepository.DeleteUser(selectedUser);

                    // Reload the DataGridView to reflect the changes
                    LoadUserData();
                }
            }
        }

        private void btn_update_prof_Click(object sender, EventArgs e)
        {
            if (SelectedUserIdForAction != -1)
            {
                var selectedUser = _userRepository.GetAllUsers()
                                                       .FirstOrDefault(u => u.Id == SelectedUserIdForAction);

                if (selectedUser != null)
                {
                    // Update the user data from form fields
                    selectedUser.Username = username.Text;
                    selectedUser.FullName = fullname.Text;
                    selectedUser.Email = email.Text;
                    selectedUser.Password = password.Text;
                    _userRepository.UpdateUser(selectedUser);
                    LoadUserData();
                    
                }
            }
        }
    }
}
