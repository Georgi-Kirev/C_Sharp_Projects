using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstInput = new List<int>();
        List<int> secondInput = new List<int>();
        // Act
        List<int> result = SameValues.FindSameValues(firstInput, secondInput);
        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstInput = new List<int>() { 1, 3, 5, 7, 8, 9 };
        List<int> secondInput = new List<int>();
        // Act
        List<int> result = SameValues.FindSameValues(firstInput, secondInput);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstInput = new List<int>() { 1, 3, 5, 7, 8, 9 };
        List<int> secondInput = new List<int>() { 10, 35, 45, 61, 81, 50 };
        // Act
        List<int> result = SameValues.FindSameValues(firstInput, secondInput);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        // Arrange
        List<int> firstInput = new List<int>() { 1, 3, 5, 7, 8, 9 };
        List<int> secondInput = new List<int>() { 1, 3, 5, 7, 8, 9 };
        List<int> expected = new List<int>() { 1, 3, 5, 7, 8, 9 };
        // Act
        List<int> result = SameValues.FindSameValues(firstInput, secondInput);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
