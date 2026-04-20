using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;

    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }

    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string nameOfProduct = "Banana";
        double priceOfProduct = 2.3;
        int quantityOfProduct = 6;
        string expected = "Product Inventory:" + Environment.NewLine +
                          "Banana - Price: $2.30 - Quantity: 6";
        // Act
        _inventory.AddProduct(nameOfProduct, priceOfProduct, quantityOfProduct);
        // Assert
        Assert.That(_inventory.DisplayInventory(), Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange

        string expected = "Product Inventory:";
        // Act
        string result = _inventory.DisplayInventory();
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        _inventory.AddProduct("Banana", 2.3, 6);
        _inventory.AddProduct("Tomato", 1.3, 10);
        // Act
        string result = _inventory.DisplayInventory();
        // Assert
        Assert.That(result, Does.Contain("Banana - Price: $2.30 - Quantity: 6"));
        Assert.That(result, Does.Contain("Tomato - Price: $1.30 - Quantity: 10"));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        double expected = 0;
        // Act
        double result = _inventory.CalculateTotalValue();
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        _inventory.AddProduct("Banana", 2.4, 10); // 24lv
        _inventory.AddProduct("Tomato", 1.3, 10);// 13 lv
        double expected = 37;
        // Act
        double result = _inventory.CalculateTotalValue();
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
