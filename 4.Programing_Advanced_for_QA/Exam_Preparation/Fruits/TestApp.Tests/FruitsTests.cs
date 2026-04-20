using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            {"banana", 3 },
            {"orange", 10 },
            {"apple", 8 }
        };
        string searching = "orange";
        int expected = 10;
        // Act
        int actual = Fruits.GetFruitQuantity(fruits, searching);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {

        // Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            {"banana", 3 },
            {"orange", 10 },
            {"apple", 8 }
        };
        string searching = "kiwi";
        int expected = 0;
        // Act
        int actual = Fruits.GetFruitQuantity(fruits, searching);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>();
        string searching = "orange";
        int expected = 0;
        // Act
        int actual = Fruits.GetFruitQuantity(fruits, searching);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruits = null;
        string searching = "orange";
        int expected = 0;
        // Act
        int actual = Fruits.GetFruitQuantity(fruits, searching);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            {"banana", 3 },
            {"orange", 10 },
            {"apple", 8 }
        };
        string searching = null;
        int expected = 0;
        // Act
        int actual = Fruits.GetFruitQuantity(fruits, searching);
        // Assert
        Assert.AreEqual(expected, actual);
    }
}
