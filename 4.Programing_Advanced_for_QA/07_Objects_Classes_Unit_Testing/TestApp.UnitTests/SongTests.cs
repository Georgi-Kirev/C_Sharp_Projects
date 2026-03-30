using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class SongTests
{
    private Song _song;

    [SetUp]
    public void Setup()
    {
        this._song = new();
    }

    // TODO: finish test
    [Test]
    public void Test_AddAndListSongs_ReturnsAllSongs_WhenWantedListIsAll()
    {
        // Arrange
        Song newSong = new Song();
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        string expected = $"Song1{Environment.NewLine}Song2{Environment.NewLine}Song3";
        string wanted = "all";
        // Act
        string result = newSong.AddAndListSongs(songs, wanted);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsFilteredSongs_WhenWantedListIsSpecific()
    {
        // Arrange
        Song newSong = new Song();
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        string expected = $"Song2";
        string wanted = "Rock";
        // Act
        string result = newSong.AddAndListSongs(songs, wanted);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsEmptyString_WhenNoSongsMatchWantedList()
    {
        // Arrange
        Song newSong = new Song();
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        string expected = string.Empty;
        string wanted = "Classic";
        // Act
        string result = newSong.AddAndListSongs(songs, wanted);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
