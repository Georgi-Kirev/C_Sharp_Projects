using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> inputedList = new List<int>() { 5 };
        // Act
        List<int> result = GaussTrick.SumPairs(inputedList);

        // Assert
        CollectionAssert.AreEqual(inputedList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> inputedList = new List<int>() { 5, 10, 100, 500, 20, 60 };
        List<int> expected = new List<int>() { 65, 30, 600 };
        // Act
        List<int> result = GaussTrick.SumPairs(inputedList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> inputedList = new List<int>() { 5, 10, 100, 500, 1000, 20, 60 };
        List<int> expected = new List<int>() { 65, 30, 1100, 500 };
        // Act
        List<int> result = GaussTrick.SumPairs(inputedList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> inputedList = new List<int>() { 5000, 200, 100, 500, 1000, 356 };
        List<int> expected = new List<int>() { 5356, 1200, 600 };
        // Act
        List<int> result = GaussTrick.SumPairs(inputedList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> inputedList = new List<int>() { 532, 810, 100, 500, 1000 };
        List<int> expected = new List<int>() { 1532, 1310, 100 };
        // Act
        List<int> result = GaussTrick.SumPairs(inputedList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
