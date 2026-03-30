using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> oddInput = new List<int>() { 1, 25, 49, 81, 121 };
        List<double> expected = new List<double>() { 1, 5, 7, 9, 11 };
        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(oddInput);
        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<int> expected = new() { 0 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> input = new() { };
        List<int> expected = new() { };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
