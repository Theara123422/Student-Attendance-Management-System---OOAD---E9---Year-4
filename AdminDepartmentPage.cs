using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Departments;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4
{
    public partial class AdminDepartmentPage : Form
    {
        private readonly DepartmentRepository _departmentRepository;
        private int SelectedIdForAction;
        public AdminDepartmentPage(DepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
            InitializeComponent();
            LoadAllDepartment();
        }

        private void btn_insert_prof_Click(object sender, EventArgs e)
        {
            btn_insert_dep.Enabled = false;

            string Department = DepartmentName.Text;
            string? FacultyName = Faculty.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(Department) || string.IsNullOrWhiteSpace(FacultyName))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_insert_dep.Enabled = true;
                return;
            }

            Department department = new Department
            {
                DepartmentName = Department,
                Faculty = FacultyName
            };

            _departmentRepository.AddDepartment(department);
            DepartmentName.Text = "";
            btn_insert_dep.Enabled = true;
            LoadAllDepartment();
        }

        private void LoadAllDepartment()
        {
            var departments = _departmentRepository.GetAllDepartments();

            dgv_depart.Rows.Clear();

            foreach (var department in departments)
            {
                dgv_depart.Rows.Add(department.Id, department.DepartmentName, department.Faculty);
            }
        }

        private void dgv_depart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                btn_edit_depart.Enabled = true;
                btn_del_depart.Enabled = true;
                int selectedId = Convert.ToInt32(dgv_depart.Rows[e.RowIndex].Cells["Id"].Value);

                SelectedIdForAction = selectedId;
            }
        }

        private void btn_edit_depart_Click(object sender, EventArgs e)
        {
            var department = _departmentRepository.GetAllDepartments().FirstOrDefault(
                            d => d.Id == SelectedIdForAction
                );

            if (department != null)
            {
                DepartmentName.Text = department.DepartmentName;
                Faculty.Text = department.Faculty;
                btn_update_depart.Enabled = true;
            }
        }

        private void btn_del_depart_Click(object sender, EventArgs e)
        {
            var selectedDepartment = _departmentRepository.GetAllDepartments()
                                     .FirstOrDefault(u => u.Id == SelectedIdForAction);

            if (selectedDepartment != null)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this department?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Call the delete method in the repository
                    _departmentRepository.DeleteDepartment(selectedDepartment);

                    // Reload the DataGridView to reflect the changes
                    LoadAllDepartment();
                }
            }
        }

        private void btn_update_depart_Click(object sender, EventArgs e)
        {
            if (SelectedIdForAction != -1)
            {
                var selectedDepartment = _departmentRepository.GetAllDepartments()
                                                       .FirstOrDefault(u => u.Id == SelectedIdForAction);

                if (selectedDepartment != null)
                {
                    selectedDepartment.DepartmentName = DepartmentName.Text;
                    selectedDepartment.Faculty = (string)Faculty.SelectedItem;
                    _departmentRepository.UpdateDepartment(selectedDepartment);
                    LoadAllDepartment();
                    DepartmentName.Text = "";
                }
            }
        }
    }
}
