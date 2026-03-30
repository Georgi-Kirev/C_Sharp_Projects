using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new List<int>();
        // Act
        string result = Grouping.GroupNumbers(input);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { 2, 4, 6, 8, 1, 3, 5, 9 };
        string expected = "Even numbers: 2, 4, 6, 8" + Environment.NewLine +
                          "Odd numbers: 1, 3, 5, 9";
        // Act
        string result = Grouping.GroupNumbers(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { 2, 4, 6, 8, 10, 30, 50, 90 };
        string expected = "Even numbers: 2, 4, 6, 8, 10, 30, 50, 90";
        // Act
        string result = Grouping.GroupNumbers(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { 1, 3, 5, 7, 17, 39, 51, 95 };
        string expected = "Odd numbers: 1, 3, 5, 7, 17, 39, 51, 95";
        // Act
        string result = Grouping.GroupNumbers(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { -1, -3, -5, -7, -10, -40, -32, -96 };
        string expected = "Odd numbers: -1, -3, -5, -7" + Environment.NewLine +
                          "Even numbers: -10, -40, -32, -96";
        // Act
        string result = Grouping.GroupNumbers(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
