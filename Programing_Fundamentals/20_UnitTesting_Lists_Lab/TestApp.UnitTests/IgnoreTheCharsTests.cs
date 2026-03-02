using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        // Arrange
        string sentence = string.Empty;
        List<char> ignoredChars = new List<char>() { 'a', 'b', 'c' };

        // Act 
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        // Arrange
        string sentence = "My name is Georgi.";
        List<char> ignoredChars = new List<char>() { };
        string expected = "My name is Georgi.";
        // Act 
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        // Arrange
        string sentence = "M";
        List<char> ignoredChars = new List<char>() { 'M' };
        string expected = "";
        // Act 
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        // Arrange
        string sentence = "My name is Georgi.";
        List<char> ignoredChars = new List<char>() { 'M', 'y', ' ', 'n', 'a', 'm', 'e', ' ', 'i', 's', ' ', 'G', 'e', 'o', 'r', 'g', 'i', '.', 'G', 'O', 'A', 'L' };
        string expected = "";
        // Act 
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
