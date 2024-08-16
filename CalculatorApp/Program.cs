using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CalculatorApp
{
    class Program
    {
        private readonly ILogger<Program> _logger;

        public Program(ILogger<Program> logger)
        {
            _logger = logger;
        }

        static void Main(string[] args)
        {
            var logger = LoggerProvider.CreateLogger<Program>();

            var program = new Program(logger);
            program.Run();
        }

        public void Run()
        {
            try
            {
                _logger.LogInformation("Calculator is running...");

                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                _logger.LogInformation("First number entered: {Number1}", num1);

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                _logger.LogInformation("Second number entered: {Number2}", num2);

                Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
                string operation = Console.ReadLine()?.ToLower() ?? string.Empty;
                _logger.LogInformation("Operation Entered: {Operation}", operation);

                // Create a logger for the Calculator class
                var calculatorLogger = LoggerProvider.CreateLogger<Calculator>();
                var calculator = new Calculator(calculatorLogger);
                double result = calculator.PerformOperation(num1, num2, operation);
                Console.WriteLine($"The result is: {result}");
                _logger.LogInformation("Calculation successful. Result: {Result}", result);
            }
            catch (FormatException ex)
            {
                _logger.LogError(ex, "Invalid input. Please enter numeric values.");
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
            catch (DivideByZeroException ex)
            {
                _logger.LogError(ex, "Cannot divide by Zero.");
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex, "Invalid operation.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _logger.LogInformation("Calculation attempt finished.");
                Console.WriteLine("Calculation attempt finished.");
            }
        }
    }
}