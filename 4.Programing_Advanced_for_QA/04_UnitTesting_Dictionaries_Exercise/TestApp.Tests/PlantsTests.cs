using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = new string[] { };
        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] { "rose" };
        string expected = "Plants with 4 letters:" + Environment.NewLine + "rose";
        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] { "rose", "tulip", "daisy", "lotus" };
        string expected = "Plants with 4 letters:" + Environment.NewLine + "rose" + Environment.NewLine +
            "Plants with 5 letters:" + Environment.NewLine + "tulip" + Environment.NewLine + "daisy" + Environment.NewLine + "lotus";
        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] { "rose", "tulip", "daisy", "lotus" };
        string expected = "Plants with 4 letters:" + Environment.NewLine + "rose" + Environment.NewLine +
            "Plants with 5 letters:" + Environment.NewLine + "tulip" + Environment.NewLine + "daisy" + Environment.NewLine + "lotus";
        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
