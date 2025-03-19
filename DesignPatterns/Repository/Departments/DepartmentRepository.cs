using Student_Attendance_Management_System___OOAD___E9___Year_4.Database;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Departments;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly AppDbContext _context;

    public DepartmentRepository(AppDbContext context)
    {
        _context = context;
    }
    public IEnumerable<Department> GetAllDepartments()
    {
        return _context.Departments.ToList();
    }

    public void AddDepartment(Department department)
    {
        try
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"Error creating Department : {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void UpdateDepartment(Department department)
    {
        try
        {
            var existingDepartment = _context.Departments.Find(department.Id);
            if (existingDepartment != null)
            {

                existingDepartment.DepartmentName = department.DepartmentName;
                existingDepartment.Faculty        = department.Faculty;


                _context.SaveChanges();

                MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Department not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating department: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void DeleteDepartment(Department department)
    {
        try
        {

            var existingDepartment= _context.Departments.Find(department.Id);
            if (existingDepartment != null)
            {

                _context.Departments.Remove(existingDepartment);


                _context.SaveChanges();

                MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Department not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error deleting department: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
