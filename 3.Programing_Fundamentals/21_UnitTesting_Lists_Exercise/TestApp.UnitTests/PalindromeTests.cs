using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> validInput = new List<string>() { "Level", "noon", "refer" };
        // Act
        bool result = Palindrome.IsPalindrome(validInput);
        // Assert
        Assert.IsTrue(result);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> validInput = new List<string>() { "radar" };
        // Act
        bool result = Palindrome.IsPalindrome(validInput);
        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> validInput = new List<string>() { "opel" };
        // Act
        bool result = Palindrome.IsPalindrome(validInput);
        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string>() { "eye", "noon", "refer", "redder", "rotator" };
        // Act
        bool result = Palindrome.IsPalindrome(input);
        // Assert
        Assert.IsTrue(result);
    }
}
