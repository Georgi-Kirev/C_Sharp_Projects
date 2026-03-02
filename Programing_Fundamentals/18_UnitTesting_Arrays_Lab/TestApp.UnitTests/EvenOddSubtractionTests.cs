using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenNums = { 2, 6, 20, 400, 30, 2 };
        int expected = 460;

        // Act
        int result = EvenOddSubtraction.FindDifference(evenNums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] oddNums = { -1, -3, -7, -101, -9, -5, -1 };
        int expected = 127;

        // Act
        int result = EvenOddSubtraction.FindDifference(oddNums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] input = { 16, 3, -7, -151, 80, -5, 10 };
        int expected = 266;

        // Act
        int result = EvenOddSubtraction.FindDifference(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
