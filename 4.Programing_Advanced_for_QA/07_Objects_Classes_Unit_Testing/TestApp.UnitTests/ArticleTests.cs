using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    // TODO: write the setup method

    // TODO: finish test
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        Article article = new Article();

        string[] stringsInput =
        {
        "Title1 Content1 Author1",
        "Title2 Content2 Author2",
        "Title3 Content3 Author3"
        };

        // Act
        Article result = article.AddArticles(stringsInput);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));

        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Title1"));
        Assert.That(result.ArticleList[0].Content, Is.EqualTo("Content1"));
        Assert.That(result.ArticleList[0].Author, Is.EqualTo("Author1"));

        Assert.That(result.ArticleList[1].Title, Is.EqualTo("Title2"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[1].Author, Is.EqualTo("Author2"));

        Assert.That(result.ArticleList[2].Title, Is.EqualTo("Title3"));
        Assert.That(result.ArticleList[2].Content, Is.EqualTo("Content3"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        Article article = new Article();
        string criteria = "title";
        string[] stringsInput =
        {
            "Title3 Content3 Author3",
            "Title1 Content1 Author1",
            "Title2 Content2 Author2"
        };
        string expected = $"Title1 - Content1: Author1{Environment.NewLine}" +
                          $"Title2 - Content2: Author2{Environment.NewLine}" +
                          $"Title3 - Content3: Author3";

        // Act
        Article test = article.AddArticles(stringsInput);
        string result = article.GetArticleList(test, criteria);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        Article article = new Article();
        string criteria = "name";
        string[] stringsInput =
        {
            "Title3 Content3 Author3",
            "Title1 Content1 Author1",
            "Title2 Content2 Author2"
        };
        string expected = string.Empty;

        // Act
        Article test = article.AddArticles(stringsInput);
        string result = article.GetArticleList(test, criteria);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
