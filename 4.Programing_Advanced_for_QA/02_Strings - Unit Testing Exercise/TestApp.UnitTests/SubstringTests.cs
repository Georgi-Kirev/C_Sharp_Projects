using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown jumps over the lazy dog";
        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "Fox";
        string input = "Fox jumps over the lazy dog";
        string expected = "jumps over the lazy dog";
        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "dog";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown fox jumps over the lazy";
        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The fox witch is quick and brown jumps over the lazy dog and the fox ran";
        string expected = "The witch is quick and brown jumps over the lazy dog and the ran";
        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.AreEqual(expected, actual);
    }
}
