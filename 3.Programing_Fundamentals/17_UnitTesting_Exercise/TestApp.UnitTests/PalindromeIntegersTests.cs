using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        PalindromeIntegers palindrome = new PalindromeIntegers();
        List<int> input = new List<int>();
        List<int> expected = new List<int>();
        // Act
        List<int> actual = palindrome.FindPalindromes(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        // Arrange
        PalindromeIntegers palindrome = new PalindromeIntegers();
        List<int> input = new List<int>() { 156 };
        List<int> expected = new List<int>();
        // Act
        List<int> actual = palindrome.FindPalindromes(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        // Arrange
        PalindromeIntegers palindrome = new PalindromeIntegers();
        List<int> input = new List<int>() { 1, 2, 3, 4 };
        List<int> expected = new List<int> { 1, 2, 3, 4 };
        // Act
        List<int> actual = palindrome.FindPalindromes(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        // Arrange
        PalindromeIntegers palindrome = new PalindromeIntegers();
        List<int> input = new List<int>() { 12321, 1001, 707 };
        List<int> expected = new List<int> { 12321, 1001, 707 };
        // Act
        List<int> actual = palindrome.FindPalindromes(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        // Arrange
        PalindromeIntegers palindrome = new PalindromeIntegers();
        List<int> input = new List<int>() { 12321, 156, 1001 };
        List<int> expected = new List<int> { 12321, 1001 };
        // Act
        List<int> actual = palindrome.FindPalindromes(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
