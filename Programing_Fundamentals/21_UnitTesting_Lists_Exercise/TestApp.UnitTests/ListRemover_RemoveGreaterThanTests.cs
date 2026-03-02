using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new List<int>();
        int secondOutput = 0;
        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, secondOutput);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new List<int>() { 12, 15, 20, 30, 34, 26, 80, 64, 51 };
        int secondOutput = 10;
        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, secondOutput);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new List<int>() { 2, 20, 15, 18, 6, 3, 12, 17, 4 };
        int secondOutput = 20;
        List<int> expected = new List<int>() { 2, 20, 15, 18, 6, 3, 12, 17, 4 };
        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, secondOutput);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> input = new List<int>() { 2, 20, 15, 18, 6, 3, 12, 17, 4, 25, 64, 84, 23, 45, 60 };
        int secondOutput = 20;
        List<int> expected = new List<int>() { 2, 20, 15, 18, 6, 3, 12, 17, 4 };
        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, secondOutput);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
