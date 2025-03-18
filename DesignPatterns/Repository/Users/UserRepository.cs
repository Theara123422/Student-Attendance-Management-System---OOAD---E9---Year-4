using Student_Attendance_Management_System___OOAD___E9___Year_4.Database;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Users
{
    public class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public void AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting user: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsUsernameTaken(string username)
        {
            return _context.Users.Any(u => u.Username == username);
        }

        public void DeleteUser(User user)
        {
            try
            {
                
                var existingUser = _context.Users.Find(user.Id);
                if (existingUser != null)
                {
                    
                    _context.Users.Remove(existingUser);

                  
                    _context.SaveChanges();

                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                var existingUser = _context.Users.Find(user.Id);
                if (existingUser != null)
                {
                    
                    existingUser.Username = user.Username;
                    existingUser.FullName = user.FullName;
                    existingUser.Email = user.Email;
                    existingUser.Password = user.Password;  
                    existingUser.Role = user.Role;

                    
                    _context.SaveChanges();

                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
