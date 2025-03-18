using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Departments;
public interface IDepartmentRepository
{
    IEnumerable<Department> GetAllDepartments();
    void AddDepartment(Department department);
    void UpdateDepartment(Department department);
    void DeleteDepartment(Department department);
}
