using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ListManipulationTests
{
    [Test]
    public void Test_RemoveNegativesAndReverse_EmptyListInput_ReturnEmptyList()
    {
        // Arrange
        List<int> emptyInput = new List<int>() { };

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(emptyInput);

        // Assert
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyNegativeNumbers_ReturnEmptyList()
    {
        // Arrange
        List<int> emptyInput = new List<int>() { -1, -3, -60, -164, -9, -53 };

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(emptyInput);

        // Assert
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyOnePositiveNumber_ReturnSameCollection()
    {
        // Arrange
        List<int> emptyInput = new List<int>() { -1, -3, 5, -60, -164, -9, -53 };
        List<int> expected = new List<int>() { 5 };
        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(emptyInput);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyPositiveNumbers_ReturnRevursedList()
    {
        // Arrange
        List<int> emptyInput = new List<int>() { 1, 3, 5, 60, 164, 9, 53 };
        List<int> expected = new List<int>() { 53, 9, 164, 60, 5, 3, 1 };
        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(emptyInput);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_PostiveAndNegativeElements_ReturnPositiveNumbersInReversedOrder()
    {
        // Arrange
        List<int> emptyInput = new List<int>() { -1, -3, 5, 60, -164, 9, 53 };
        List<int> expected = new List<int>() { 53, 9, 60, 5 };
        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(emptyInput);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
