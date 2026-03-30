using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        // Arrange
        List<int> emptyList = new List<int>() { };

        // Act
        (List<int> evenResult, List<int> oddResult) = ListSplitter.SplitEvenAndOdd(emptyList);

        // Assert
        Assert.That(evenResult, Is.Empty);
        Assert.That(oddResult, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        // Arrange
        List<int> inputList = new List<int>() { 2, 4, 8, 12, 120, 60, 40 };
        List<int> expectedEven = new List<int>() { 2, 4, 8, 12, 120, 60, 40 };
        List<int> expectedOdd = new List<int>();
        // Act
        (List<int> evenResult, List<int> oddResult) = ListSplitter.SplitEvenAndOdd(inputList);

        // Assert
        Assert.AreEqual(evenResult, expectedEven);
        Assert.AreEqual(oddResult, expectedOdd);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        // Arrange
        List<int> inputList = new List<int>() { 1, 3, 7, 19, 33, 39, 11 };
        List<int> expectedEven = new List<int>();
        List<int> expectedOdd = new List<int>() { 1, 3, 7, 19, 33, 39, 11 };
        // Act
        (List<int> evenResult, List<int> oddResult) = ListSplitter.SplitEvenAndOdd(inputList);

        // Assert
        Assert.AreEqual(evenResult, expectedEven);
        Assert.AreEqual(oddResult, expectedOdd);
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        // Arrange
        List<int> inputList = new List<int>() { 1, 3, 7, 19, 33, 39, 11, 2, 6, 8, 12, 60, 40, 20, 22 };
        List<int> expectedEven = new List<int>() { 2, 6, 8, 12, 60, 40, 20, 22 };
        List<int> expectedOdd = new List<int>() { 1, 3, 7, 19, 33, 39, 11 };
        // Act
        (List<int> evenResult, List<int> oddResult) = ListSplitter.SplitEvenAndOdd(inputList);

        // Assert
        Assert.AreEqual(evenResult, expectedEven);
        Assert.AreEqual(oddResult, expectedOdd);
    }
}
