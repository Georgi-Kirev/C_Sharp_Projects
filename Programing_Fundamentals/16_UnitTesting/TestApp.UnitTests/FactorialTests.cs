using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int num = 0;
        // Act
        int actual = Factorial.CalculateFactorial(num);
        // Assert
        Assert.AreEqual(1, actual);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int num = 4;

        // Act
        int actual = Factorial.CalculateFactorial(num);

        // Assert
        Assert.AreEqual(24, actual);

    }
}
