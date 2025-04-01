using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Decorator;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Students;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    public partial class AdminStudentPage : Form
    {
        private int SelectedIdForAction;
        private readonly ClassesRepository _classesRepository;
        private readonly StudentRepository _studentRepository;
        private readonly IValidator _stringValidator;
        public AdminStudentPage(ClassesRepository classesRepository, StudentRepository studentRepository)
        {
            _classesRepository = classesRepository;
            _studentRepository = studentRepository;
            _stringValidator = new StringValidators();
            InitializeComponent();
            LoadAllStudents();
            LoadAllClassesIntoComboBox();
        }

        private void LoadAllClassesIntoComboBox()
        {
            var classes = _classesRepository.GetAllClasses().Select(c => new { c.ID, c.ClassName }).ToList();

            StudentClass.DataSource = classes;
            StudentClass.DisplayMember = "ClassName";
            StudentClass.ValueMember = "ID";
        }

        private void dgv_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_del_student.Enabled = true;
                btn_edit_student.Enabled = true;

                SelectedIdForAction = Convert.ToInt32(dgv_student.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        private void btn_insert_student_Click(object sender, EventArgs e)
        {
            btn_insert_student.Enabled = false;

            string FullName = StudentFirstName.Text + " " + StudentLastName.Text;
            string Gender = StudentGender.SelectedItem as string;
            int ClassId = (int)StudentClass.SelectedValue;

            bool isFullNameValid = _stringValidator.Validate(FullName);

            if (!isFullNameValid)
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_insert_student.Enabled = true;
                return;
            }

            var student = new Student
            {
                FullName = FullName,
                Gender = Gender,
                ClassId = ClassId,
                Status = Utils.StudentStatus.Active
            };

            _studentRepository.CreateStudent(student);
            StudentFirstName.Text = "";
            btn_insert_student.Enabled = true;
            LoadAllStudents();


        }
        private void LoadAllStudents()
        {
            var students = _studentRepository.GetAllStudents();

            dgv_student.Rows.Clear();

            foreach (var student in students)
            {
                var classInfo = _classesRepository.GetAllClasses().FirstOrDefault(c => c.ID == student.ClassId);
                dgv_student.Rows.Add(
                    student.Id,
                    student.FullName,
                    student.Gender,
                    classInfo.ClassName,
                    student.Status
                );
            }
        }

        private void btn_edit_student_Click(object sender, EventArgs e)
        {
            var selectedStudent = _studentRepository.GetAllStudents().FirstOrDefault(s => s.Id == SelectedIdForAction);

            if (selectedStudent != null)
            {
                string[] stuVal = selectedStudent.FullName.Split(' ');
                StudentFirstName.Text = stuVal[0];
                StudentLastName.Text = stuVal[1];
                StudentGender.SelectedItem = selectedStudent.Gender;
            }
        }

        private void btn_del_student_Click(object sender, EventArgs e)
        {
            var selectedStudent = _studentRepository.GetAllStudents()
                                      .FirstOrDefault(s => s.Id == SelectedIdForAction);

            if (selectedStudent != null)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this student?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    _studentRepository.DeleteStudent(selectedStudent);
                    LoadAllStudents();
                }
            }
        }

        private void btn_update_student_Click(object sender, EventArgs e)
        {
            if (SelectedIdForAction != -1)
            {
                var selectedStudent = _studentRepository.GetAllStudents()
                                                       .FirstOrDefault(s => s.Id == SelectedIdForAction);

                if (selectedStudent != null)
                {
                    selectedStudent.FullName = StudentFirstName.Text + " " + StudentLastName.Text;
                    selectedStudent.Gender   = StudentGender.SelectedItem as string;
                    selectedStudent.ClassId = (int)StudentClass.SelectedValue;
                    _studentRepository.UpdateStudent(selectedStudent);
                    LoadAllStudents();
                }
            }
        }
    }
}
