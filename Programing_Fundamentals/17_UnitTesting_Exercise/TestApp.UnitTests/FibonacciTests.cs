using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int num = 0;
        int expected = 0;
        // Act
        int actual = Fibonacci.CalculateFibonacci(num);

        // Assert
        Assert.AreEqual(expected, actual);


    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int num = 6;
        int expected = 8;
        // Act
        int actual = Fibonacci.CalculateFibonacci(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}