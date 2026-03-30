using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    // TODO: write the setup method

    // TODO: finish test
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        Vehicles newVehicle = new Vehicles();
        string[] input = { "Cars/Ford/Focus/120", "Cars/Toyota/Camry/150", "Truck/Volvo/VNL/500" };
        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}Toyota: Camry - 150hp{Environment.NewLine}Trucks:{Environment.NewLine}Volvo: VNL - 500kg";

        // Act
        string result = newVehicle.AddAndGetCatalogue(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        // Arrange
        Vehicles newVehicle = new Vehicles();
        string[] input = { };
        string expected = $"Cars:{Environment.NewLine}Trucks:";

        // Act
        string result = newVehicle.AddAndGetCatalogue(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
