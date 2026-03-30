using NUnit.Framework;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = new char[] { '1', 'a', '3', 'b' };
        char[] expected = { 'a', 'b' };
        // Act
        char[] result = Fake.RemoveStringNumbers(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = new char[] { 'h', 'a', 'k', 'b' };
        char[] expected = { 'h', 'a', 'k', 'b' };
        // Act
        char[] result = Fake.RemoveStringNumbers(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = new char[] { };
        char[] expected = { };
        // Act
        char[] result = Fake.RemoveStringNumbers(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
