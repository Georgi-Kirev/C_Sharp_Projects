using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);
        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> inputNums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        // Act
        string result = AdjacentEqual.Sum(inputNums);
        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5 6 7 8 9 10 11 1 2 3 4 5 6 7 8 9 10 11"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> inputNums = new List<int>() { 1, 1, 1, 1, 8, 2, 2, 2, 2, 3, 3, 3, 3, 100, 4, 4, 4, 4, 5, 5, 5, 5, 500 };
        // Act
        string result = AdjacentEqual.Sum(inputNums);
        // Assert
        Assert.That(result, Is.EqualTo("4 8 8 12 100 16 20 500"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> inputNums = new List<int>() { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
        // Act
        string result = AdjacentEqual.Sum(inputNums);
        // Assert
        Assert.That(result, Is.EqualTo("120"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> inputNums = new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 6 };
        // Act
        string result = AdjacentEqual.Sum(inputNums);
        // Assert
        Assert.That(result, Is.EqualTo("8 2 3 4 5 6"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> inputNums = new List<int>() { 1, 2, 3, 4, 5, 6, 6, 6, 6, 6, 6, 6, 6 };
        // Act
        string result = AdjacentEqual.Sum(inputNums);
        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5 48"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> inputNums = new List<int>() { 0, 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 5, 6 };
        // Act
        string result = AdjacentEqual.Sum(inputNums);
        // Assert
        Assert.That(result, Is.EqualTo("0 1 2 24 4 5 6"));
    }
}
