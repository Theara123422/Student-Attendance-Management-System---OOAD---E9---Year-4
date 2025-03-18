using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

public class Department : BaseModel
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column("name")]
    public string DepartmentName { get; set; }

    [Required]
    [StringLength(100)]
    [Column("faculty")]
    public string Faculty { get; set; }

    public List<Classes> Classes { get; set; }
}
