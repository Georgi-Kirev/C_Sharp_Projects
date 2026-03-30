using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] { };

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.AreEqual(-1, result);

    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] { 1 };

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.AreEqual(-1, result);

    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] { 1, 50, 30, 8, 100, 20 };

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.AreEqual(-1, result);

    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] { -1, -1 };

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.AreEqual(-1, result);

    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] input = new int[] { 10, 10, 10, 10, 10, 10, 10 };

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.AreEqual(10, result);

    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] input = new int[] { 20, 20, 1, 5, 20, 20 };

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.AreEqual(20, result);

    }
}
