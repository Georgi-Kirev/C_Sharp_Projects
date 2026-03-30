using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    // TODO: finish the test
    [TestCase("fGEORGI4@gMail5.cOm")]
    [TestCase("sarSTAnli6r@oiSbanan3.coC")]
    [TestCase("bananWiTh6@sIedes2.coM")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish the test
    [TestCase("GeorдDAафgi@gmail.com")]
    [TestCase("Познаваш ли го този. лайф")]
    [TestCase("12365dsa4987iwan.om")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }
}
