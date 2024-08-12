namespace CalculatorApp;

public class Calculator
{
    public double PerformOperation(double num1, double num2, string operation)
    {
        // TODO: Implement the PerformOperation method
        // throw new NotImplementedException();
        switch (operation)
        {
            case "add":
                return add(num1, num2);
            case "subtract":
                return subtract(num1, num2);
            case "multiply":
                return multiply(num1, num2);
            case "divide":
                return divide(num1, num2);
            default:
                throw new InvalidOperationException("An error occurred: The specified operation is not supported.");
        }

    }

    public double add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double subtract(double num1, double num2)
    {
        return num1 - num2;
    }
    public double multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double divide(double num1, double num2)
    {
        if (num2 != 0)
            return num1 / num2;
        else
            throw new DivideByZeroException("Cannot divide by zero.");
    }
}