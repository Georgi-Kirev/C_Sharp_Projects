using NUnit.Framework;

namespace TestApp.Tests;

public class EvenNumbersTests
{
    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsGreaterThanEnd()
    {
        // Arrange
        int startNum = 10;
        int endNum = 5;
        string expected = "Start number should be smaller than end number.";
        // Act
        string actual = EvenNumbers.GetEvenNumbersInRange(startNum, endNum);
        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsNegative()
    {
        // Arrange
        int startNum = -10;
        int endNum = 5;
        string expected = "Start number should be positive number.";
        // Act
        string actual = EvenNumbers.GetEvenNumbersInRange(startNum, endNum);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEmptyResult_WhenStartAndEndAreEqualOddNumbers()
    {
        // Arrange
        int startNum = 5;
        int endNum = 5;
        string expected = "Empty result";
        // Act
        string actual = EvenNumbers.GetEvenNumbersInRange(startNum, endNum);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsSingleEvenNumber_WhenStartAndEndAreEqualEvenNumbers()
    {
        // Arrange
        int startNum = 2;
        int endNum = 2;
        string expected = "2";
        // Act
        string actual = EvenNumbers.GetEvenNumbersInRange(startNum, endNum);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenRangeHasEvens()
    {
        // Arrange
        int startNum = 2;
        int endNum = 11;
        string expected = "2, 4, 6, 8, 10";
        // Act
        string actual = EvenNumbers.GetEvenNumbersInRange(startNum, endNum);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreEvenNumbers()
    {
        // Arrange
        int startNum = 2;
        int endNum = 10;
        string expected = "2, 4, 6, 8, 10";
        // Act
        string actual = EvenNumbers.GetEvenNumbersInRange(startNum, endNum);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreOddNumbers()
    {
        // Arrange
        int startNum = 1;
        int endNum = 11;
        string expected = "2, 4, 6, 8, 10";
        // Act
        string actual = EvenNumbers.GetEvenNumbersInRange(startNum, endNum);
        // Assert
        Assert.AreEqual(expected, actual);
    }
}
