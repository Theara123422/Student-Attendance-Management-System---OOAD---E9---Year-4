using Microsoft.EntityFrameworkCore;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Database;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Dto;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Students;

public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _context;

    public StudentRepository(AppDbContext context)
    {
        _context = context;
    }
    public IEnumerable<Student> GetAllStudents()
    {
        return _context.Students.ToList();
    }

    public void CreateStudent(Student student)
    {
        try
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error inserting student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void DeleteStudent(Student student)
    {
        try
        {
            var existingStudent = _context.Students.Find(student.Id);
            if (existingStudent != null)
            {
                _context.Students.Remove(existingStudent);
                _context.SaveChanges();
                MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error deleting student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    public void UpdateStudent(Student student)
    {
        try
        {
            var existingStudent = _context.Students.Find(student.Id);
            if (existingStudent != null)
            {
                existingStudent.FullName = student.FullName;
                existingStudent.Gender   = student.Gender;
                existingStudent.ClassId  = student.ClassId;
                _context.SaveChanges();

                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public List<MarkAttendanceInfo> GetMarkAttendanceInfos(int ClassId)
    {
        var results = (from classes in _context.Classes
               join student in _context.Students on classes.ID equals student.ClassId 
               join attendance in _context.Attendances on student.Id equals attendance.StudentId into attendanceGroup
               from attendance in attendanceGroup.DefaultIfEmpty()
               where classes.ID == ClassId && attendance.date == DateTime.Today
                       select new MarkAttendanceInfo
               {
                  StudentId = student.Id,
                  StudentName = student.FullName,
                  Section = student.Section.ToString(),
                  Status  = attendance == null ? "Present" : "Absent"
               }).ToList();
        return results;
    }
}
