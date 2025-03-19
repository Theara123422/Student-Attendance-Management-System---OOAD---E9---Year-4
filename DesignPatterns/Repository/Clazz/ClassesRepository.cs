using Student_Attendance_Management_System___OOAD___E9___Year_4.Database;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;

public class ClassesRepository : IClassRepository
{
    private readonly AppDbContext _context;

    public ClassesRepository(AppDbContext context)
    {
        _context = context;
    }
    public IEnumerable<Classes> GetAllClasses()
    {
        return _context.Classes.ToList();
    }

    public void AddClass(Classes classes)
    {
        try
        {
            _context.Classes.Add(classes);
            _context.SaveChanges();
            MessageBox.Show("Class added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error creating Class : {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void DeleteClass(Classes classes)
    {
        try
        {
            var existingClass = _context.Classes.Find(classes.ID);
            if (existingClass != null)
            {
                _context.Classes.Remove(existingClass);
                _context.SaveChanges();
                MessageBox.Show("Class deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Class not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error deleting class: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void UpdateClass(Classes classes)
    {
        try
        {
            var existingClass = _context.Classes.Find(classes.ID);
            if (existingClass != null)
            {
                existingClass.ClassName = classes.ClassName;
                existingClass.DepartmentId = classes.DepartmentId;
                existingClass.UserId = classes.UserId;

                _context.SaveChanges();

                MessageBox.Show("Class updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Class not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating class: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
