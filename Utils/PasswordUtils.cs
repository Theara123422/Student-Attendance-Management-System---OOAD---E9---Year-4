using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Strategy;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Utils
{
    public class PasswordUtils
    {
        private static IPasswordHashStrategy _strategy = new MD5Strategy();
        public static void SetHashStrategy(IPasswordHashStrategy strategy)
        {
            _strategy = strategy;
        }

        public static string HashPassword(string password)
        {
            return _strategy.HashPassword(password);
        }

        public static bool VerifyPassword(string inputPassword, string storedHash)
        {
            return _strategy.VerifyPassword(inputPassword, storedHash);
        }
    }
}
