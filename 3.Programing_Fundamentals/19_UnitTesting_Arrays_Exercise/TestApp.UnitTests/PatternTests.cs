using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] input = new int[] { 3, 2, 1, };
        int[] expected = { 1, 3, 2 };
        // Act
        int[] result = Pattern.SortInPattern(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = new int[] { };
        int[] expected = { };
        // Act
        int[] result = Pattern.SortInPattern(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] input = new int[] { 4 };
        int[] expected = { 4 };
        // Act
        int[] result = Pattern.SortInPattern(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
