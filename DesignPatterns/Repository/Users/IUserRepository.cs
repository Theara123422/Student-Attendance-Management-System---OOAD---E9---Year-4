using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Users
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
