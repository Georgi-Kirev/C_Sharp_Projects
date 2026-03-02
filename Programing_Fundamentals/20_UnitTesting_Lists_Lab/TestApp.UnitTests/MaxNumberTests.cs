using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> list = new List<int>() { 1 };

        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(1, result);

    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() { 1, 5, 30, 2, 15, 6 };
        int expected = 30;
        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() { -1, -5, -30, -2, -15, -6 };
        int expected = -1;
        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() { -1, 5, -30, 2, 15, -6 };
        int expected = 15;
        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() { 1, 5, 30, 30, 2, 15, 6, 6, 2, 1 };
        int expected = 30;
        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(expected, result);

    }
}
