using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [Test]
    public void Test_GradeAsWords_ReturnsCorrectString()
    {
        // Arrange
        double grade = 3.00;
        string expected = "Average";
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases()
    {
        // Arrange
        double grade = 6.01;
        string expected = "Invalid!";
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
