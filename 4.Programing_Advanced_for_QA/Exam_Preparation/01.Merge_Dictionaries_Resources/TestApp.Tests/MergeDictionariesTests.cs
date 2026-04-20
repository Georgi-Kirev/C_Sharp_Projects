using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class MergeDictionariesTests
{
    [Test]
    public void Test_Merge_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDic = new Dictionary<string, int>();
        Dictionary<string, int> secondDic = new Dictionary<string, int>();

        Dictionary<string, int> expected = new Dictionary<string, int>();
        // Act
        Dictionary<string, int> actual = MergeDictionaries.Merge(firstDic, secondDic);
        // Assert
        Assert.That(actual, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_Merge_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsNonEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDic = new Dictionary<string, int>()
        {
            { "BMW", 1 },
            { "Volvo", 2 },
            { "Mercedes", 3 },
            { "Opel", 4 },
        };
        Dictionary<string, int> secondDic = new Dictionary<string, int>();

        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            { "BMW", 1 },
            { "Volvo", 2 },
            { "Mercedes", 3 },
            { "Opel", 4 },
        };
        // Act
        Dictionary<string, int> actual = MergeDictionaries.Merge(firstDic, secondDic);
        // Assert
        Assert.That(actual, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_Merge_TwoNonEmptyDictionaries_ReturnsMergedDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDic = new Dictionary<string, int>()
        {
            { "BMW", 1 },
            { "Volvo", 2 },
            { "Mercedes", 3 },
            { "Opel", 4 },
        };
        Dictionary<string, int> secondDic = new Dictionary<string, int>()
        {
            { "Banana", 10 },
            { "Orange", 12 },
            { "Lemon", 5 },
            { "Apple", 8 }

        };

        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            { "BMW", 1 },
            { "Volvo", 2 },
            { "Mercedes", 3 },
            { "Opel", 4 },
            { "Banana", 10 },
            { "Orange", 12 },
            { "Lemon", 5 },
            { "Apple", 8 },
        };
        // Act
        Dictionary<string, int> actual = MergeDictionaries.Merge(firstDic, secondDic);
        // Assert
        Assert.That(actual, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_Merge_OverlappingKeys_ReturnsMergedDictionaryWithValuesFromDict2()
    {
        // Arrange
        Dictionary<string, int> firstDic = new Dictionary<string, int>()
        {
            { "BMW", 1 },
            { "Volvo", 2 },
            { "Mercedes", 3 },
            { "Opel", 4 },
        };
        Dictionary<string, int> secondDic = new Dictionary<string, int>()
        {
            { "Opel", 10 },
            { "Orange", 12 },
            { "Lemon", 5 },
            { "Apple", 8 }

        };

        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            { "BMW", 1 },
            { "Volvo", 2 },
            { "Mercedes", 3 },
            { "Opel", 10 },
            { "Orange", 12 },
            { "Lemon", 5 },
            { "Apple", 8 },
        };
        // Act
        Dictionary<string, int> actual = MergeDictionaries.Merge(firstDic, secondDic);
        // Assert
        Assert.That(actual, Is.EquivalentTo(expected));
    }
}
