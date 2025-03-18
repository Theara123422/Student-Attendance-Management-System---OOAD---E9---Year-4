using System.Security.Cryptography;
using System.Text;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Utils
{
    public static class PasswordUtils
    {
        public static string HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // Convert byte to hex string
                }
                return sb.ToString();
            }
        }

        public static bool VerifyPassword(string inputPassword, string storedHash)
        {
            string hashedInput = HashPassword(inputPassword);
            return hashedInput == storedHash;
        }
    }
}
