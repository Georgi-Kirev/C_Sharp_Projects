using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("Building", 3, "bUiLdInGbUiLdInGbUiLdInG")]
    [TestCase("Car", 2, "cArcAr")]
    [TestCase("Tomato", 4, "tOmAtOtOmAtOtOmAtOtOmAtO")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input,
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = "";
        int repetitionFactor = 2;
        string expected = "Input string cannot be empty, and repetition factor must be positive.";
        // Act
        var actual = Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
        // Assert
        Assert.That(actual.Message, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "Bucket";
        int repetitionFactor = -2;
        string expected = "Input string cannot be empty, and repetition factor must be positive.";
        // Act
        var actual = Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
        // Assert
        Assert.That(actual.Message, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "Bucket";
        int repetitionFactor = 0;
        string expected = "Input string cannot be empty, and repetition factor must be positive.";
        // Act
        var actual = Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
        // Assert
        Assert.That(actual.Message, Is.EqualTo(expected));
    }
}
