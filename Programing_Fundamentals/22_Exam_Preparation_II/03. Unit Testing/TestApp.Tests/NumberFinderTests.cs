using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

public class NumberFinderTests
{
    [Test]
    public void Test_FindSmallestPositive_ShouldReturnError_WhenListIsNull()
    {
        // Arrange
        List<int> numbers = null;
        string expected = "List cannot be empty.";
        // Act
        string actual = NumberFinder.FindSmallestPositive(numbers);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnError_WhenListIsEmpty()
    {
        // Arrange
        List<int> numbers = new List<int>();
        string expected = "List cannot be empty.";
        // Act
        string actual = NumberFinder.FindSmallestPositive(numbers);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnSmallest_WhenListHasPositiveNumbers()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, 3, 5, 8, 100, 50, 35, 40 };
        string expected = "Smallest positive number is: 1";
        // Act
        string actual = NumberFinder.FindSmallestPositive(numbers);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnSmallest_WhenListHasMixedNumbers()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, -3, 5, 8, -100, 50, -35, 40 };
        string expected = "Smallest positive number is: 1";
        // Act
        string actual = NumberFinder.FindSmallestPositive(numbers);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnNotFoundMessage_WhenAllNumbersAreNegativeOrZero()
    {
        // Arrange
        List<int> numbers = new List<int>() { -1, -3, -5, 0, -8, -100, -50, -35, -40 };
        string expected = "No positive numbers found.";
        // Act
        string actual = NumberFinder.FindSmallestPositive(numbers);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldHandleDuplicates_Correctly()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, 3, 5, 0, 8, 100, 50, 35, 40, 100, 50, 35 };
        string expected = "Smallest positive number is: 1";
        // Act
        string actual = NumberFinder.FindSmallestPositive(numbers);
        // Assert
        Assert.AreEqual(expected, actual);
    }
}
