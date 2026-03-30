using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = { "", "", "", "", "" };
        string expected = string.Empty;
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] input = { "Water" };
        string expected = "Water";
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = { "Water", "Beer", "Vodka", "Rakia", "Wine", "Building", "Mall" };
        string expected = "MallBuildingWineRakiaVodkaBeerWater";
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = null;
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] input = { "Wat er", "Be er", "Vo d ka", "R ak i a", "Wi ne" };
        string expected = "Wi neR ak i aVo d kaBe erWat er";
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = { "Water", "Beer", "Vodka", "Rakia", "Wine", "Car", "Train", "Plane", "Boat" };
        string expected = "BoatPlaneTrainCarWineRakiaVodkaBeerWater";
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
