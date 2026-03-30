using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] count = new int[] { };
        // Act
        string result = CountRealNumbers.Count(count);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] count = new int[] { 2 };
        string expected = "2 -> 1";
        // Act
        string result = CountRealNumbers.Count(count);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] count = new int[7] { 2, 3, 10, 5, 50, 30, 20 };
        string expected = "2 -> 1" + Environment.NewLine +
                          "3 -> 1" + Environment.NewLine +
                          "5 -> 1" + Environment.NewLine +
                          "10 -> 1" + Environment.NewLine +
                          "20 -> 1" + Environment.NewLine +
                          "30 -> 1" + Environment.NewLine +
                          "50 -> 1";
        // Act
        string result = CountRealNumbers.Count(count);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] count = new int[7] { -2, -3, -10, -5, -50, -30, -20 };
        string expected = "-50 -> 1" + Environment.NewLine +
                          "-30 -> 1" + Environment.NewLine +
                          "-20 -> 1" + Environment.NewLine +
                          "-10 -> 1" + Environment.NewLine +
                          "-5 -> 1" + Environment.NewLine +
                          "-3 -> 1" + Environment.NewLine +
                          "-2 -> 1";
        // Act
        string result = CountRealNumbers.Count(count);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] count = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        string expected = "0 -> 7";
        // Act
        string result = CountRealNumbers.Count(count);
        // Assert
        Assert.AreEqual(expected, result);
    }
}
