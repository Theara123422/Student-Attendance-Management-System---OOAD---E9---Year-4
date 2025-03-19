using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;
namespace Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;

public interface IClassRepository
{
    IEnumerable<Classes> GetAllClasses();

    void AddClass(Classes classes); 
    void DeleteClass(Classes classes);
    void UpdateClass(Classes classes);
}
