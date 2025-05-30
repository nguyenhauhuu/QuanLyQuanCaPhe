using System;
using System.IO;

public static class Logger
{
    private static readonly object _lock = new object();
    private static readonly string _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lafm_log.txt");

    public static void GhiLog(string message)
    {
        string log = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";

        lock (_lock)
        {
            File.AppendAllText(_logFilePath, log + Environment.NewLine);
        }

        Console.WriteLine(log);
    }

    // Optional: Ghi lỗi nếu cần
    public static void GhiLoi(Exception ex)
    {
        string message = $"LỖI: {ex.Message}\nStackTrace: {ex.StackTrace}";
        GhiLog(message);
    }
}
