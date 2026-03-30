using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] { };

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.AreEqual(-1, result);
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] { 1 };

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.AreEqual(-1, result);
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.AreEqual(-1, result);
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] { -1, -1 };

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.AreEqual(-1, result);
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] input = new int[] { 23, 23, 23, 23, 23, 23, 23, 23 };

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.AreEqual(23, result);
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] input = new int[] { 56, 56, 5, 6, 3, 8 };

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.AreEqual(56, result);
    }
}
