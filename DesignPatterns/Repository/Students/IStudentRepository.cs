using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Students;

public interface IStudentRepository
{
    IEnumerable<Student> GetAllStudents();
    void CreateStudent(Student student);
    void DeleteStudent(Student student);
    void UpdateStudent(Student student);
}
