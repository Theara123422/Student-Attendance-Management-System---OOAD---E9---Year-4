using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Student_Attendance_Management_System___OOAD___E9___Year_4;
using Student_Attendance_Management_System___OOAD___E9___Year_4.Database;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Observer.Attendances;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Clazz;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Departments;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Students;
using Student_Attendance_Management_System___OOAD___E9___Year_4.DesignPatterns.Repository.Users;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        // Load configuration from appsettings.json
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        var connectionString = config.GetConnectionString("DefaultConnection");
        var services = new ServiceCollection();
        services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)),ServiceLifetime.Transient
        );
        services.AddTransient<LoginForm>();
        services.AddTransient<UserRepository>();
        services.AddTransient<DepartmentRepository>();
        services.AddTransient<ClassesRepository>();
        services.AddTransient<StudentRepository>();
        services.AddTransient<AttendanceRepository>();

        var serviceProvider = services.BuildServiceProvider();

      
        //TestDatabaseConnection(serviceProvider);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(serviceProvider.GetRequiredService<LoginForm>());
    }

    private static void TestDatabaseConnection(IServiceProvider serviceProvider)
    {
        using (var context = serviceProvider.GetRequiredService<AppDbContext>())
        {
            try
            {
                var users = context.Users.Take(1).ToList();
                MessageBox.Show("Database connection successful!", "Connection Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
