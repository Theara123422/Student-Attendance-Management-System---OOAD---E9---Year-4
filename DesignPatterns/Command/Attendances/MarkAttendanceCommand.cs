using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Observer.Attendances;
namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Command.Attendances;

public class MarkAttendanceCommand : ICommands
{
    private readonly AttendanceRepository _attendanceRepository;
    private readonly int _studentId;
    private readonly int _markBy;
    private readonly int _status;

    public MarkAttendanceCommand(AttendanceRepository attendanceRepository, int studentId, int markBy)
    {
        _attendanceRepository = attendanceRepository;
        _studentId = studentId;
        _markBy = markBy;
        _status = 1;
    }

    public void Execute()
    {
        bool success = _attendanceRepository.MarkAttendance(_studentId, _markBy, _status);

        if (success)
        {
            MessageBox.Show("Attendance has been updated in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("There was an issue updating the attendance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
