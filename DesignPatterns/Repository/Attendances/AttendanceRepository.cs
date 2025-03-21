using Student_Attendance_Management_System___OOAD___E9___Year_4.Database;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Utils;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Observer.Attendances
{
    public class AttendanceRepository
    {
        private readonly AppDbContext _context;
        private List<IAttendanceObserver> _observers = new List<IAttendanceObserver>();
        public AttendanceRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool MarkAttendance(int studentId, int markBy, int status)
        {
            var attendance = new Attendance
            {
                StudentId = studentId,
                MarkedBy = markBy,
                status = (AttendanceStatus) status,
                date = DateTime.Now
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return true; 
        }
    }
}
