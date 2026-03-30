using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        // Arrange
        int[] input = new int[] { };
        TopIntegers ti = new TopIntegers();
        // Act
        string result = ti.FindTopIntegers(input);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        // Arrange
        int[] input = new int[] { 5, 4, 3, 2, 1 };
        TopIntegers ti = new TopIntegers();
        string expected = "5 4 3 2 1";
        // Act
        string result = ti.FindTopIntegers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        // Arrange
        int[] input = new int[] { 3 };
        TopIntegers ti = new TopIntegers();
        string expected = "3";
        // Act
        string result = ti.FindTopIntegers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        // Arrange
        int[] input = new int[] { 4, 1, 3, 2 };
        TopIntegers ti = new TopIntegers();
        string expected = "4 3 2";
        // Act
        string result = ti.FindTopIntegers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

