using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWord = new string[] { "georgi" };
        string text = "He ate the banana.";
        // Act
        string result = TextFilter.Filter(bannedWord, text);
        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWord = new string[] { "are", "banana" };
        string text = "He are the sauce with no banana.";
        string expected = "He *** the sauce with no ******.";
        // Act
        string actual = TextFilter.Filter(bannedWord, text);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWord = Array.Empty<string>();
        string text = "He ate the banana";
        // Act
        string actual = TextFilter.Filter(bannedWord, text);
        // Assert
        Assert.That(actual, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWord = new string[] { "bad fox", "lazy dog" };
        string text = "The quick bad fox jumps over the lazy dog";
        string expected = "The quick ******* jumps over the ********";
        // Act
        string actual = TextFilter.Filter(bannedWord, text);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
