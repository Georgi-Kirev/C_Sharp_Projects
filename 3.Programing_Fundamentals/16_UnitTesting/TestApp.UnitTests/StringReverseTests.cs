using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "L";
        string expected = "L";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "gogo";
        string expected = "ogog";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, actual);

    }
}
