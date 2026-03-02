using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [Test]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage()
    {
        // Arrange
        string num = "zero";
        string expected = "The input is not an integer!";

        // Act
        string actual = SignOfIntegerNumbers.CheckSign(num);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        // Arrange
        string num = "0";
        string expected = $"The number {num} is zero.";

        // Act
        string actual = SignOfIntegerNumbers.CheckSign(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {
        // Arrange
        string num = "-2";
        string expected = $"The number {num} is negative.";

        // Act
        string actual = SignOfIntegerNumbers.CheckSign(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        // Arrange
        string num = "2";
        string expected = $"The number {num} is positive.";

        // Act
        string actual = SignOfIntegerNumbers.CheckSign(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
