using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        // Arrange
        int[] input = new int[] { };
        int expected = 0;
        // Act
        int result = Majority.IsEvenOrOddMajority(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        // Arrange
        int[] input = new int[] { 0, 0, 0, 0, 0, 0, };
        int expected = 0;
        // Act
        int result = Majority.IsEvenOrOddMajority(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        // Arrange
        int[] input = new int[] { 1, 3, 5, 6, 8, 10 };
        int expected = 0;
        // Act
        int result = Majority.IsEvenOrOddMajority(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        // Arrange
        int[] input = new int[] { 2, 4, 6, 8, 1, 5, 3, 7, 2 };
        int expected = 1;
        // Act
        int result = Majority.IsEvenOrOddMajority(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        // Arrange
        int[] input = new int[] { 1, 3, 5, 7, 9, 6, 2, 4, 10 };
        int expected = -1;
        // Act
        int result = Majority.IsEvenOrOddMajority(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
