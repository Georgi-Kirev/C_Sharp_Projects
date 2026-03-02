using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new List<int>();
        int secondOutput = 0;
        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, secondOutput);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new List<int>() { 1, 12, 5, 6, 8, 10, -5 };
        int secondOutput = 12;
        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, secondOutput);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new List<int>() { 13, 25, 31, 42, 84, 60, 840, 20 };
        int secondOutput = 12;
        List<int> expected = new List<int>() { 13, 25, 31, 42, 84, 60, 840, 20 };
        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, secondOutput);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        // Arrange
        List<int> input = new List<int>() { 13, 25, 31, 42, 84, 60, 840, 20, 12, 5, -4, 10, 3, 7 };
        int secondOutput = 12;
        List<int> expected = new List<int>() { 13, 25, 31, 42, 84, 60, 840, 20 };
        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, secondOutput);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
