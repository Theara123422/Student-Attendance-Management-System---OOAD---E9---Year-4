using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;
namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    public partial class TeacherClassesPage : Form
    {
        private User _user;
        private readonly ClassesRepository _classesRepository;
        public TeacherClassesPage(User user, ClassesRepository classesRepository)
        {
            _user = user;
            _classesRepository = classesRepository;
            InitializeComponent();
            ActiveTeacherLabel.Text = $"All Active Class of {_user.FullName}";
            LoadAllClassesByUserId();
        }

        private void LoadAllClassesByUserId()
        {
            var classes = _classesRepository.GetClassByUserId(_user.Id);

            dgv_teacher_classes.Rows.Clear();

            foreach (var clazz in classes)
            {
                dgv_teacher_classes.Rows.Add(clazz.ID, clazz.ClassName, clazz.Section, _user.FullName);
            }
        }
    }
}
