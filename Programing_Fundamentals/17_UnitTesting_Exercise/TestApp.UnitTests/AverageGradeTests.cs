using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        // Arrange
        List<double> num = new List<double> { -1, 0, 1.99 };
        string expected = "Incorrect grades";
        // Act
        string actual = AverageGrade.GetGradeDefinition(num);

        // Assert
        Assert.AreEqual(expected, actual);


    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        // Arrange
        List<double> num = new List<double> { 6.1, 7, 10 };
        string expected = "Incorrect grades";
        // Act
        string actual = AverageGrade.GetGradeDefinition(num);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {
        // Arrange
        List<double> num = new List<double> { 2, 2.5, 2.99 };
        string expected = "Fail";
        // Act
        string actual = AverageGrade.GetGradeDefinition(num);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        // Arrange
        List<double> num = new List<double> { 3, 3.4, 3.49 };
        string expected = "Poor";
        // Act
        string actual = AverageGrade.GetGradeDefinition(num);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        // Arrange
        List<double> num = new List<double> { 3.5, 4, 4.49 };
        string expected = "Good";
        // Act
        string actual = AverageGrade.GetGradeDefinition(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        // Arrange
        List<double> num = new List<double> { 4.5, 5, 5.49 };
        string expected = "Very good";
        // Act
        string actual = AverageGrade.GetGradeDefinition(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        // Arrange
        List<double> num = new List<double> { 5.5, 5.8, 6 };
        string expected = "Excellent";
        // Act
        string actual = AverageGrade.GetGradeDefinition(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
