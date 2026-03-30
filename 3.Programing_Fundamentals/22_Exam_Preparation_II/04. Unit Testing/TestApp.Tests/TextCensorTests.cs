using NUnit.Framework;

namespace TestApp.Tests;

public class TextCensorTests
{
    [Test]
    public void CensorWord_ShouldReturnError_WhenSentenceIsNull()
    {
        // Arrange
        string inputSentence = null;
        string wordToCensor = "domat";
        string expected = "Sentence cannot be empty.";
        // Act
        string actual = TextCensor.CensorWord(inputSentence, wordToCensor);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenSentenceIsWhitespace()
    {
        // Arrange
        string inputSentence = "      ";
        string wordToCensor = "banan";
        string expected = "Sentence cannot be empty.";
        // Act
        string actual = TextCensor.CensorWord(inputSentence, wordToCensor);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenWordIsNull()
    {
        // Arrange
        string inputSentence = "My name is Ivan.";
        string wordToCensor = null;
        string expected = "Word to censor cannot be empty.";
        // Act
        string actual = TextCensor.CensorWord(inputSentence, wordToCensor);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenWordIsWhitespace()
    {
        // Arrange
        string inputSentence = "I love to play.";
        string wordToCensor = "      ";
        string expected = "Word to censor cannot be empty.";
        // Act
        string actual = TextCensor.CensorWord(inputSentence, wordToCensor);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CensorWord_ShouldReplaceSingleOccurrence()
    {
        // Arrange
        string inputSentence = "My name is Georgi!";
        string wordToCensor = "is";
        string expected = "My name ** Georgi!";
        // Act
        string actual = TextCensor.CensorWord(inputSentence, wordToCensor);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CensorWord_ShouldReplaceMultipleOccurrences()
    {
        // Arrange
        string inputSentence = "My name is Georgi and he is bad coder!";
        string wordToCensor = "is";
        string expected = "My name ** Georgi and he ** bad coder!";
        // Act
        string actual = TextCensor.CensorWord(inputSentence, wordToCensor);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CensorWord_ShouldReturnOriginal_WhenWordNotFound()
    {
        // Arrange
        string inputSentence = "My name is Georgi!";
        string wordToCensor = "Terran";
        string expected = "My name is Georgi!";
        // Act
        string actual = TextCensor.CensorWord(inputSentence, wordToCensor);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CensorWord_ShouldReplaceCaseInsensitive()
    {
        // Arrange
        string inputSentence = "My name is Georgi and my mood is bad!";
        string wordToCensor = "My";
        string expected = "** name is Georgi and ** mood is bad!";
        // Act
        string actual = TextCensor.CensorWord(inputSentence, wordToCensor);
        // Assert
        Assert.AreEqual(expected, actual);
    }
}

