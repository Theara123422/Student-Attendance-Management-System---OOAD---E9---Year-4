using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Observer.Attendances;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Students;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Utils;
namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    public partial class MarkAttendancePage : Form
    {
        private User _user;
        private readonly ClassesRepository _classesRepository;
        private readonly StudentRepository _studentRepository;
        private readonly AttendanceRepository _attendanceRepository;
        public MarkAttendancePage(User user, ClassesRepository classesRepository, StudentRepository studentRepository, AttendanceRepository attendanceRepository)
        {
            
            _attendanceRepository = attendanceRepository;
            _studentRepository = studentRepository;
            _user = user;
            _classesRepository = classesRepository;
            InitializeComponent();
            LoadAllClassesByUserId();
        }

        private void LoadAllClassesByUserId()
        {
            var classes = _classesRepository.GetClassByUserId(_user.Id);

            dgv_teacher_attendance.Rows.Clear();
            DateTime currentDate = DateTime.Now;
            int hour = currentDate.Hour;
            string SectionTime = TimesUtils.GetSectionTimeForDay(hour);
            foreach (var cls in classes)
            {
                if (string.Equals(cls.Section.ToString(), SectionTime, StringComparison.OrdinalIgnoreCase))
                {
                    dgv_teacher_attendance.Rows.Add(cls.ID, cls.ClassName, cls.Section, _user.FullName);
                }
            }
        }

        private void dgv_teacher_attendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               int ClassId = Convert.ToInt32(dgv_teacher_attendance.Rows[e.RowIndex].Cells[0].Value);
                AttendanceForm attendanceForm = new AttendanceForm(ClassId, _studentRepository, _attendanceRepository,_user);
                attendanceForm.Show();
            }
            
        }
    }
}
