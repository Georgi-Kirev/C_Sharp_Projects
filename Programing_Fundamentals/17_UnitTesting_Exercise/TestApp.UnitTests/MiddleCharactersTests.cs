using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string input = "";
        string expected = "Empty string";
        // Act
        string actual = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string input = " ";
        string expected = "Empty string";
        // Act
        string actual = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        // Arrange
        string input = "a";
        string expected = "a";
        // Act
        string actual = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        // Arrange
        string input = "ab";
        string expected = "ab";
        // Act
        string actual = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        // Arrange
        string input = "iao";
        string expected = "a";
        // Act
        string actual = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.AreEqual(expected, actual);

    }
}
