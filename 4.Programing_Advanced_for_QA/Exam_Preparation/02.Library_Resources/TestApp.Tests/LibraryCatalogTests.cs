using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestApp.Library;

namespace TestApp.Tests;

[TestFixture]
public class LibraryCatalogTests
{
    private LibraryCatalog _catalog = null!;

    [SetUp]
    public void SetUp()
    {
        this._catalog = new();
    }

    [Test]
    public void Test_AddBook_BookAddedToCatalog()
    {
        // Arrange
        string isnt = "1234567890";
        string title = "Harry Potter";
        string autor = "Joanne Rowling";
        _catalog.AddBook(isnt, title, autor);
        string expected = "Library Catalog:" + Environment.NewLine +
                          "Harry Potter by Joanne Rowling (ISBN: 1234567890)";
        // Act
        string actual = _catalog.DisplayCatalog();
        // Assert
        Assert.That(actual, Is.EquivalentTo(expected));

    }

    [Test]
    public void Test_GetBook_BookExists_ReturnsBook()
    {
        // Arrange
        string isnt = "1234567890";
        string title = "Harry Potter";
        string autor = "Joanne Rowling";
        _catalog.AddBook(isnt, title, autor);

        Book expected = new Book(isnt, title, autor);

        // Act
        Book actual = _catalog.GetBook(isnt);
        // Assert
        Assert.That(actual.Isbn, Is.EqualTo(expected.Isbn));
        Assert.That(actual.Title, Is.EqualTo(expected.Title));
        Assert.That(actual.Author, Is.EqualTo(expected.Author));
    }

    [Test]
    public void Test_GetBook_BookDoesNotExist_ThrowsArgumentException()
    {
        // Arrange
        string isnt = "1234567890";
        string title = "Harry Potter";
        string autor = "Joanne Rowling";
        _catalog.AddBook(isnt, title, autor);

        Book expected = new Book(isnt, title, autor);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _catalog.GetBook("0987654321"), "Book with given ISBN does not exist.");
    }

    [Test]
    public void Test_DisplayCatalog_NoBooks_ReturnsEmptyString()
    {
        // Arrange
        string expected = "";
        // Act
        string actual = _catalog.DisplayCatalog();
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayCatalog_WithBooks_ReturnsFormattedCatalog()
    {
        // Arrange
        _catalog.AddBook("1234567890", "Harry Potter", "Joanne Rowling");
        _catalog.AddBook("2040608010", "Lord of The Rings", "John Ronald Reuel Tolkien");
        _catalog.AddBook("9998885551", "Mamnik", "Vasil Popov");
        string expected = "Library Catalog:" + Environment.NewLine +
                          "Harry Potter by Joanne Rowling (ISBN: 1234567890)" + Environment.NewLine +
                          "Lord of The Rings by John Ronald Reuel Tolkien (ISBN: 2040608010)" + Environment.NewLine +
                          "Mamnik by Vasil Popov (ISBN: 9998885551)";
        // Act
        string actual = _catalog.DisplayCatalog();
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
