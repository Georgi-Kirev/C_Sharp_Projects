using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = { "" };
        string expected = string.Empty;
        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(input);

        // Assert
        Assert.That(expected, Is.EqualTo(result));

    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = { "Lemon" };
        string expected = string.Empty;

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = { "Lemon", "Pumpkin", "Spinach", "Pears" };
        string expected = string.Empty;

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(input);

        // Assert
        Assert.IsTrue(expected.Equals(result));

    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        // Arrange
        string[] input = { "Banana" };
        string expected = "Banana";

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(input);

        // Assert
        Assert.That(expected.Equals(result));

    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        // Arrange
        string[] input = { "Banana", "Lemon", "Tomato", "Orange", "Pears" };
        string expected = "Banana Tomato Orange";
        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(input);

        // Assert
        Assert.That(expected.Equals(result));
    }
}

