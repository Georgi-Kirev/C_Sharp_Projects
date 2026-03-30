using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();


        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] oneElement = { 462 };

        // Act
        string result = Reverse.ReverseArray(oneElement);

        // Assert
        Assert.That(result, Is.EqualTo("462"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] inputs = { 1, 5, 40, 60, -15, 10 };
        string expected = "10 -15 60 40 5 1";

        // Act
        string result = Reverse.ReverseArray(inputs);

        // Assert
        Assert.That(result, Is.EqualTo(expected));


    }
}
