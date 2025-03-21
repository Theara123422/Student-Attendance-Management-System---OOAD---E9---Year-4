namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Utils;

public class TimesUtils
{
    public static string GetSectionTimeForDay(int hour)
    {
        if (hour >= 7 && hour < 12)
        {
            return "Morning";
        }
        else if (hour >= 14 && hour < 16)
        {
            return "Afternoon";
        }
        else
        {
            return "Evening";
        }
    }
}
