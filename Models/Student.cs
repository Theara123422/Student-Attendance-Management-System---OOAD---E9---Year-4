using Student_Attendance_Management_System___OOAD___E9___Year_4.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

public class Student : BaseModel
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Column("full_name")]
    public string FullName { get; set; }

    [Required]
    [Column("section")]
    public Section Section { get; set; }

    [Required]
    [Column("status")]
    public StudentStatus Status { get; set; } = StudentStatus.Active;

    [Required]
    public List<Attendance> Attendances { get; set; }

    [Column("class_id")]
    public int ClassId { get; set; }
    [Required]
    public Classes Classes { get; set; }
}
