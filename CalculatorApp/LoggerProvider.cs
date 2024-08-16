using Microsoft.Extensions.Logging;

namespace CalculatorApp;

public static class LoggerProvider
{
    private static readonly ILoggerFactory LoggerFactory = Microsoft.Extensions.Logging.LoggerFactory.Create(builder =>
    {
        builder
            .AddFilter("Microsoft", LogLevel.Warning)
            .AddFilter("System", LogLevel.Warning)
            .AddFilter("LoggingConsoleApp.Program", LogLevel.Debug)
            .AddConsole()
            .AddDebug();
    });

    public static ILogger<T> CreateLogger<T>()
    {
        var logger = LoggerFactory.CreateLogger<T>();

        return logger;
    }
}