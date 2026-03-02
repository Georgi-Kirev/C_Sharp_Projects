using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

public class NumberUtilitiesTests
{
    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenNoNumbersDivisibleByThree()
    {
        // Arrange
        List<int> numbers = new List<int>() { 2, 4, 7, 11 };
        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsEmpty()
    {
        // Arrange
        List<int> numbers = new List<int>();
        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsNull()
    {
        // Arrange
        List<int> numbers = null;
        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnSingleNumber_WhenOnlyOneDivisibleByThree()
    {
        // Arrange
        List<int> numbers = new List<int>() { 2, 4, 7, 11, 3 };
        string expected = "3";
        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnOnlyNumbersDivisibleByThree_WhenListHasMixedValues()
    {
        // Arrange
        List<int> numbers = new List<int>() { 2, 4, 7, 11, 3, 9, 12, 6 };
        string expected = "3, 9, 12, 6";
        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldHandleNegativeNumbersCorrectly()
    {
        // Arrange
        List<int> numbers = new List<int>() { -2, -4, -7, -11, -3 };
        string expected = "-3";
        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnUniqueNumbers_WhenListHasDuplicates()
    {
        // Arrange
        List<int> numbers = new List<int>() { 2, 4, 7, 11, 3, 3, 4, 7, 11 };
        string expected = "3";
        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

}
