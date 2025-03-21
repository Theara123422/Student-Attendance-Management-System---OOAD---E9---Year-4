using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Observer.Attendances;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Students;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;
namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    public partial class AttendanceForm : Form, IAttendanceObserver
    {
        private readonly AttendanceRepository _attendanceRepository;
        private readonly StudentRepository _studentRepository;
        private readonly User _user;
        private int _studentId;
        public AttendanceForm(int StudentId, StudentRepository studentRepository, AttendanceRepository attendanceRepository, User user)
        {
            _studentId = StudentId;
            _attendanceRepository = attendanceRepository;
            _studentRepository = studentRepository;
           
            _user = user;
            InitializeComponent();

            LoadAllStudents();
        }

        private void LoadAllStudents()
        {
            dgv_attendance_student.Rows.Clear();
            var students = _studentRepository.GetMarkAttendanceInfos(_studentId);
            foreach (var student in students)
            {
                dgv_attendance_student.Rows.Add(student.StudentId, student.StudentName, student.Section, student.Status);
            }
        }

        public void Updates()
        {
            LoadAllStudents();
        }

        private void dgv_attendance_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int StudentId = Convert.ToInt32(dgv_attendance_student.Rows[e.RowIndex].Cells["Id"].Value);
                BtnMarkAttendanceForm btnMarkAttendanceForm = new BtnMarkAttendanceForm(StudentId,_user,_attendanceRepository);
                btnMarkAttendanceForm.Subscribe(this);
                btnMarkAttendanceForm.Show();
            }
            
        }
    }
}
