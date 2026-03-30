using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long num = 11;
        long expected = 11;
        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(num);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {

        // Arrange
        long num = long.MaxValue;
        long expected = 649657;
        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
