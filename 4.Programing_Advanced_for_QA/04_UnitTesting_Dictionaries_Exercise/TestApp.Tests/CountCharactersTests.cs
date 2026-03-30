using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new List<string>() { "" };
        // Act
        string result = CountCharacters.Count(input);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "s" };
        string expected = "s -> 1";
        // Act
        string result = CountCharacters.Count(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "saad", "das", "dqq", "asq" };
        string expected = "s -> 3" + Environment.NewLine +
                          "a -> 4" + Environment.NewLine +
                          "d -> 3" + Environment.NewLine +
                          "q -> 3";
        // Act
        string result = CountCharacters.Count(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "@@##", "$$", "$$", "&&&&" };
        string expected = "@ -> 2" + Environment.NewLine +
                          "# -> 2" + Environment.NewLine +
                          "$ -> 4" + Environment.NewLine +
                          "& -> 4";
        // Act
        string result = CountCharacters.Count(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
