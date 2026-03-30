using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        double expected = 3;

        // Act
        double result = Average.CalculateAverage(input);

        // Assert
        Assert.That($"{result:F2}", Is.EqualTo($"{expected:F2}"));

    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] negativeInput = { -1, -2, -3, -4, -5 };
        double expected = -3;
        // Act
        double result = Average.CalculateAverage(negativeInput);

        // Assert
        Assert.That($"{result:F2}", Is.EqualTo($"{expected:F2}"));

    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] mixedInput = { 10, 5, 100, -20, 60, -54, 234 };
        double expected = 47.857142857143;
        // Act
        double result = Average.CalculateAverage(mixedInput);

        // Assert
        Assert.That($"{result:F2}", Is.EqualTo($"{expected:F2}"));

    }
}
