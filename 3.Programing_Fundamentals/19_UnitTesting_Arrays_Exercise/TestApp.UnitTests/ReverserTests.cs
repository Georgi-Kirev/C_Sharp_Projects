using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] input = new string[] { "Banana" };
        string[] expected = new string[] { "ananaB" };
        // Act
        string[] result = Reverser.ReverseStrings(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] input = new string[] { "Banana", "Tomato", "Lemon", "Eggplant" };
        string[] expected = new string[] { "ananaB", "otamoT", "nomeL", "tnalpggE" };
        // Act
        string[] result = Reverser.ReverseStrings(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] input = new string[] { "shovel%", "#axe", "hamm#r" };
        string[] expected = new string[] { "%levohs", "exa#", "r#mmah" };

        // Act
        string[] result = Reverser.ReverseStrings(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);

    }
}
