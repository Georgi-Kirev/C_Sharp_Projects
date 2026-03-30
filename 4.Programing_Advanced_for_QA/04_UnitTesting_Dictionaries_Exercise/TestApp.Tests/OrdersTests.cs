using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { };
        // Act
        string actial = Orders.Order(input);
        // Assert
        Assert.That(actial, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 1.99 3", "banana 1.25 3", "orange 1.98 1" };
        string expected = "apple -> 5.97" + Environment.NewLine +
                          "banana -> 3.75" + Environment.NewLine +
                          "orange -> 1.98";
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 2.123 3", "banana 1.321 3", "orange 4.456 1" };
        string expected = "apple -> 6.37" + Environment.NewLine +
                          "banana -> 3.96" + Environment.NewLine +
                          "orange -> 4.46";
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 2 2.40", "banana 2 2.2", "orange 2 1.2" };
        string expected = "apple -> 4.80" + Environment.NewLine +
                          "banana -> 4.40" + Environment.NewLine +
                          "orange -> 2.40";
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
