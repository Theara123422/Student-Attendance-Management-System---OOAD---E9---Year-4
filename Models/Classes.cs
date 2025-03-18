using Student_Attendance_Management_System___OOAD___E9___Year_4.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

public class Classes : BaseModel
{
    [Key]
    [Column("id")]
    public int ID { get; set; }

    [Required]
    [StringLength(10)]
    [Column("class_name")]
    public string ClassName { get; set; }

    [Required]
    [StringLength(10)]
    [Column("section")]
    public Section Section { get; set; }

    [Required]
    [Column("year")]
    public int year { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }
    [Required]
    public User User { get; set; }

    [Column("department_id")]
    public int DepartmentId  { get; set; }
    [Required]
    public Department Department { get; set; }

    [Required]
    public List<Student> Students { get; set; }
}
