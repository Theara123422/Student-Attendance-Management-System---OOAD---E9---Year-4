﻿using Student_Attendance_Management_System___OOAD___E9___Year_4.Database;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Dto;
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

    public List<StudentClassDepartmentInfo> GetClassDepartmentUserStudentCount()
    {
        var result = (from clazz in _context.Classes
                      join department in _context.Departments on clazz.DepartmentId equals department.Id
                      join user in _context.Users on clazz.UserId equals user.Id
                      join student in _context.Students on clazz.ID equals student.ClassId into classStudents
                      select new StudentClassDepartmentInfo
                      {
                         ClassId = clazz.ID,
                         ClassName = clazz.ClassName,
                         DepartmentName = department.DepartmentName,
                         ProfessorName = user.FullName,
                         TotalStudent = classStudents.Count()
                      }).ToList();

        return result;
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

    public List<Classes> GetClassByUserId(int userId)
    {
        return _context.Classes.Where(c => c.UserId == userId).ToList();
    }
}
