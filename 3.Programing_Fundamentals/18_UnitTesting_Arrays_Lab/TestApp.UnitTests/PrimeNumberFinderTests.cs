using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithElementsOnlyLessThanOrEqualToOne_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = new int[] { -1, 1, 0 };

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneElementNonPrimeNumber_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = new int[] { 6 };

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = new int[] { 6, 9, 10, 0 };

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneElementPrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        // Arrange
        int[] input = new int[] { 7 };
        int[] expected = new int[] { 7 };
        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        // Arrange
        int[] input = new int[] { 3, 6, 11, 7, 9, 10, -4 };
        int[] expected = new int[] { 3, 11, 7 };
        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(input);

        // Assert
        Assert.AreEqual(expected, result);

    }
}
