using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Models;

    public abstract class BaseModel
    {
        [Required]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Timestamp]
        [Column("row_version")]
        public byte[] RowVersion { get; set; } = new byte[8];

        [Column("updated_at")]
        public DateTime UpdatedAt {  get; set; } = DateTime.UtcNow;
    }
