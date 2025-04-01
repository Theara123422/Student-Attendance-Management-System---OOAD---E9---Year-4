using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Departments;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Users;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Utils;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    public partial class AdminClassesPage : Form
    {
        private readonly User _user;
        private readonly ClassesRepository _classesRepository;
        private readonly UserRepository _userRepository;
        private readonly DepartmentRepository _departmentRepository;
        private int SelectedIdForAction;
        public AdminClassesPage(ClassesRepository classesRepository, UserRepository userRepository, DepartmentRepository departmentRepository, User user)
        {
            _userRepository = userRepository;
            _classesRepository = classesRepository;
            _departmentRepository = departmentRepository;
            _user = user;
            InitializeComponent();
            LoadAllClasses();
            LoadAllUserIntoComboBox();
            LoadDepartmentsIntoComboBox();
        }

        private void LoadDepartmentsIntoComboBox()
        {
            var departments = _departmentRepository.GetAllDepartments().Select(d => new { d.DepartmentName, d.Id }).ToList();
            ClassDepartment.Items.Clear();

            ClassDepartment.DataSource = departments;
            ClassDepartment.DisplayMember = "DepartmentName";
            ClassDepartment.ValueMember = "Id";

        }

        private void LoadAllUserIntoComboBox()
        {
            var users = _userRepository.GetAllUsers().Select(u => new { u.FullName, u.Id }).ToList();
            ClassProfessor.Items.Clear();

            ClassProfessor.DataSource = users;
            ClassProfessor.DisplayMember = "FullName";
            ClassProfessor.ValueMember = "Id";
        }

        private void dgv_classes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_edit_class.Enabled = true;
                btn_del_class.Enabled = true;
                int selectedId = Convert.ToInt32(dgv_classes.Rows[e.RowIndex].Cells[0].Value);

                SelectedIdForAction = selectedId;
            }
        }

        private void btn_insert_class_Click(object sender, EventArgs e)
        {
            btn_insert_class.Enabled = false;

            string ClassName = ClassLabel.Text;
            int DepartmentId = Convert.ToInt32(ClassDepartment.SelectedValue);
            int Year = ClassYear.Text == "Freshman" ? 1 : ClassYear.Text == "Sophomore" ? 2 : ClassYear.Text == "Junior" ? 3 : 4;
            int Section = ClassSection.Text == "Morning" ? 0 : ClassSection.Text == "Afternoon" ? 1 : 2;
            int UserId = (int) ClassProfessor.SelectedValue;

            if (string.IsNullOrWhiteSpace(ClassName))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_insert_class.Enabled = true;
                return;
            }

            Classes clazz = new Classes
            {
                ClassName = ClassName,
                DepartmentId = DepartmentId,
                year = Year,
                Section = (Section)Section,
                UserId = UserId
            };

            _classesRepository.AddClass(clazz);
            ClassLabel.Text = "";
            LoadAllClasses();

        }
        private void LoadAllClasses()
        {
            var classes = _classesRepository.GetAllClasses();

            dgv_classes.Rows.Clear();

            foreach (var clazz in classes)
            {
                var departmentInfo = _departmentRepository.GetAllDepartments()
                        .Where(d => d.Id == clazz.DepartmentId)
                        .Select(d => new { d.DepartmentName, d.Faculty })
                        .FirstOrDefault();

                dgv_classes.Rows.Add(
                    clazz.ID,
                    clazz.ClassName,
                    departmentInfo.DepartmentName,
                    departmentInfo.Faculty,
                    clazz.year,
                    clazz.Section,
                    0
                );
            }
        }

        private void btn_edit_class_Click(object sender, EventArgs e)
        {
            var selectedClasses = _classesRepository.GetAllClasses().FirstOrDefault(c => c.ID == SelectedIdForAction);

            if (selectedClasses != null)
            {
                ClassLabel.Text = selectedClasses.ClassName;
                ClassDepartment.SelectedValue = selectedClasses.DepartmentId;
                ClassYear.SelectedItem = selectedClasses.year == 1 ? "Freshman" : selectedClasses.year == 2 ? "Sophomore" : selectedClasses.year == 3 ? "Junior" : "Senior";
            }
        }

        private void btn_del_class_Click(object sender, EventArgs e)
        {
            var selectedClasses = _classesRepository.GetAllClasses()
                                      .FirstOrDefault(u => u.ID == SelectedIdForAction);

            if (selectedClasses != null)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this class?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    
                    _classesRepository.DeleteClass(selectedClasses);
                    LoadAllClasses();
                }
            }
        }

        private void btn_update_class_Click(object sender, EventArgs e)
        {
            if (SelectedIdForAction != -1)
            {
                var selectedClasses = _classesRepository.GetAllClasses()
                                                       .FirstOrDefault(u => u.ID == SelectedIdForAction);

                if (selectedClasses != null)
                {
                    selectedClasses.ClassName = ClassLabel.Text;
                    selectedClasses.DepartmentId = Convert.ToInt32(ClassDepartment.SelectedValue);
                    selectedClasses.year =  ClassYear.Text == "Freshman" ? 1 : ClassYear.Text == "Sophomore" ? 2 : ClassYear.Text == "Junior" ? 3 : 4;
                    selectedClasses.Section = (Section) (ClassSection.Text == "Morning" ? 0 : ClassSection.Text == "Afternoon" ? 1 : 2);
                    selectedClasses.UserId = _user.Id; 
                    _classesRepository.UpdateClass(selectedClasses);
                    LoadAllClasses();

                }
            }
        }
    }
}
