namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Decorator;

public class EmailValidator : IValidator
{
    public bool Validate(string input)
    {
        var emailRegex = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        return emailRegex.IsMatch(input);
    }
}
