﻿namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

            var calculator = new Calculator();    
            double result = calculator.PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}"); 
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally {
            Console.WriteLine("Calculation attempt finished.");
        }
    }
}