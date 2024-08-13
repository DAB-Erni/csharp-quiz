using NUnit.Framework;

namespace CalculatorApp.UnitTests;

[TestFixture]
public class CalculatorTest
{
    [Test]
    // public void MethodUnderTest_Scenario_ExpectedBehavior()
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        double num1 = 5;
        double num2 = 10;

        var unitUnderTest = new Calculator();
        double testResult = unitUnderTest.Add(num1, num2);
        double expectedResult = 15;

        Assert.That(testResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Subtract_TwoNumbers_ReturnsCorrectDifference()
    {
        double num1 = 20;
        double num2 = 15;

        var unitUnderTest = new Calculator();
        double testResult = unitUnderTest.Subtract(num1, num2);
        double expectedResult = 5;

        Assert.That(testResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Multiply_TwoNumbers_ReturnsCorrectProduct()
    {
        double num1 = 10;
        double num2 = 3;

        var unitUnderTest = new Calculator();
        double testResult = unitUnderTest.Multiply(num1, num2);
        double expectedResult = 30;

        Assert.That(testResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Divide_TwoNumbers_ReturnsCorrectQuotient()
    {
        double num1 = 30;
        double num2 = 5;

        var unitUnderTest = new Calculator();
        double testResult = unitUnderTest.Divide(num1, num2);
        double expectedResult = 6;

        Assert.That(testResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Divide_NumberByZero_ThrowsDivideByZeroException()
    {
        double num1 = 5;
        double num2 = 0;

        var unitUnderTest = new Calculator();

        Assert.Throws<DivideByZeroException>(() => unitUnderTest.Divide(num1, num2));
    }

    [Test]
    public void Operation_InvalidInput_ThrowsFormatException()
    {
        string num1 = "abc";
        var num2 = 5;

        var unitUnderTest = new Calculator();

        Assert.Throws<FormatException>(() => unitUnderTest.Divide(double.Parse(num1), num2));
    }

}