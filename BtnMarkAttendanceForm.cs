using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Command.Attendances;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Observer.Attendances;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;
using System;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    public partial class BtnMarkAttendanceForm : Form, IAttendanceObserverSubject
    {
        private int StudentId;
        private AttendanceInvoker _attendanceInvoker;
        private User _user;
        private readonly AttendanceRepository _attendanceRepository;
        private List<IAttendanceObserver> _observers;
        public BtnMarkAttendanceForm(int StudentId, User user, AttendanceRepository attendanceRepository)
        {
            _user = user;
            this.StudentId = StudentId;
            _attendanceInvoker = new AttendanceInvoker();
            InitializeComponent();
            _attendanceRepository = attendanceRepository;
            MarkFor.Text = $"Mark for Student ID: {StudentId}";
            _observers = new List<IAttendanceObserver>();
        }

        public void Subscribe(IAttendanceObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IAttendanceObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Updates();
            }
        }

        private void MarkAttendance(string status)
        {
            ICommands command = status.ToLower() switch
            {
                "present" => new MarkAttendanceCommand(_attendanceRepository, StudentId, _user.Id),
                "absent" => new MarkAbsentCommand(_attendanceRepository, StudentId, _user.Id),
                "permission" => new MarkPermissionCommand(_attendanceRepository, StudentId, _user.Id),
                _ => throw new ArgumentException("Invalid attendance status")
            };
            _attendanceInvoker.SetCommand(command);
            _attendanceInvoker.ExecuteCommand();
            NotifyObservers();
        }

        private void btn_present_Click(object sender, EventArgs e)
        {
            btn_absent.Enabled = false;
            btn_permission.Enabled = false;
            MarkAttendance("Present");
            this.Hide();
        }

        private void btn_absent_Click(object sender, EventArgs e)
        {
            btn_permission.Enabled = false;
            btn_present.Enabled = false;
            MarkAttendance("Absent");
            this.Hide();
        }

        private void btn_permission_Click(object sender, EventArgs e)
        {
            btn_present.Enabled = false;
            btn_absent.Enabled = false;
            MarkAttendance("Permission");
            this.Hide();
        }
    }
}
