namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Decorator;

internal class StringValidators : IValidator
{
    public bool Validate(string input)
    {
        return !string.IsNullOrEmpty(input);
    }
}
