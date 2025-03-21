namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Strategy;

public interface IPasswordHashStrategy
{
    string HashPassword(string password);
    bool VerifyPassword(string password, string hashedPassword);
}

