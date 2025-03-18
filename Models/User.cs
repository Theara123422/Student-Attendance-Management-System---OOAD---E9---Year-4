using Student_Attendance_Management_System___OOAD___E9___Year_4.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Models;
public class User : BaseModel
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Column("username")]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    [Column("email")]
    public string Email { get; set; }

    [Required]
    [StringLength(255)]
    [Column("password")]
    public string Password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = PasswordUtils.HashPassword(value);
        }
    }
    private string _password;

    [Required]
    [MaxLength(50)]
    [Column("full_name")]
    public string FullName { get; set; }

    [Required]
    [Column("role")]
    public Role Role { get; set; }

    [StringLength(255)]
    [Required]
    [Column("educational_background")]
    public string EducationalBackground { get; set; }

    [Required]
    [Column("status")]
    public TeacherStatus Status { get; set; }

    [Required]
    public List<Attendance> Attendances { get; set; }

    [Required]
    public List<Classes> Classes { get; set; }
}
