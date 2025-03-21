using System;
using System.IO;

public sealed class Logger
{
    private static readonly Logger _instance = new Logger();
    private readonly string logFilePath;

    private Logger()
    {
        string projectDir = AppDomain.CurrentDomain.BaseDirectory;

        logFilePath = Path.Combine(projectDir, @"..\..\..\log.txt");

        
        if (!File.Exists(logFilePath))
        {
            File.Create(logFilePath).Dispose();
        }
    }

    public static Logger Instance => _instance;

    public void Log(string message)
    {
        string logMessage = $"{DateTime.Now}: {message}";
        try
        {
            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Logging error: {ex.Message}");
        }
    }
}
