using Microsoft.EntityFrameworkCore;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Models;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Utils;

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Classes> Classes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string hashedPassword = PasswordUtils.HashPassword("Admin@123");
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,  
                Username = "pentheara",
                Email = "theara123@gmail.com",
                Password = hashedPassword,
                FullName = "Pen Theara",
                Role = Role.Admin,
                Attendances = new List<Attendance>(),
                Classes = new List<Classes>(),
                EducationalBackground = "Computer Science",
                Status = TeacherStatus.Active
            });


            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.User)
                .WithMany(u => u.Attendances)
                .HasForeignKey(a => a.MarkedBy);

            modelBuilder.Entity<Attendance>()
                .HasOne(s => s.Student)
                .WithMany(a => a.Attendances)
                .HasForeignKey(f => f.StudentId);

            modelBuilder.Entity<Student>()
                .HasOne(c => c.Classes)
                .WithMany(s => s.Students)
                .HasForeignKey(f => f.ClassId);

            modelBuilder.Entity<Classes>()
                .HasOne(u => u.User)
                .WithMany(c => c.Classes)
                .HasForeignKey(f => f.UserId);

            modelBuilder.Entity<Classes>()
                .HasOne(d => d.Department)
                .WithMany(c => c.Classes)
                .HasForeignKey(d => d.DepartmentId);
        }

       
    }
}
