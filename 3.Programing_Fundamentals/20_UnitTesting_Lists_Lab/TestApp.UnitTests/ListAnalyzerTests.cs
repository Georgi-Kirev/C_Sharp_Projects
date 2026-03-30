using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        // Arrange
        List<int> emptyList = new List<int>();
        string expected = "No elements!";
        // Act
        string result = ListAnalyzer.Analyze(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> emptyList = new List<int>() { 2 };
        string expected = $"Element count: 1, Min value: 2, Max value: 2, Avg: 2.00.";
        // Act
        string result = ListAnalyzer.Analyze(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> emptyList = new List<int>() { 2, 2, 2, 2, 2 };
        string expected = $"Element count: 5, Min value: 2, Max value: 2, Avg: 2.00.";
        // Act
        string result = ListAnalyzer.Analyze(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Analyze_DiffrentValues_ShouldReturnCorrectValues()
    {
        // Arrange
        List<int> emptyList = new List<int>() { 2, 3, 10, 6, 40, 31 };
        string expected = $"Element count: 6, Min value: 2, Max value: 40, Avg: 15.33.";
        // Act
        string result = ListAnalyzer.Analyze(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
