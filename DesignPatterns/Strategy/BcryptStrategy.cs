using BCrypt.Net;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Strategy;

public class BCryptHashStrategy : IPasswordHashStrategy
{
    public string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public bool VerifyPassword(string password, string hashedPassword)
    {
        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
    }
}
