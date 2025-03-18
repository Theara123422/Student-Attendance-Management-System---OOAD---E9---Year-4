using Student_Attendance_Management_System___OOAD___E9___Year_4.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

public class Attendance : BaseModel
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    public DateTime date { get; set; } = DateTime.UtcNow;

    [Required]
    public AttendanceStatus status { get; set; } = AttendanceStatus.Present;

    [Column("marked_by")]
    public int MarkedBy { get; set; }

    [Required]
    public User User { get; set; }

    [Column("student_id")]
    public int StudentId { get; set; }
    [Required]
    public Student Student { get; set; }
}
