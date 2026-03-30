using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "domato";
        string expected = "otamod";
        // Act
        string result = _exceptions.ArgumentNullReverse(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string? input = null;
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal totalPrice = 50;
        decimal discount = 20;
        decimal expected = 40;
        // Act
        decimal result = _exceptions.ArgumentCalculateDiscount(totalPrice, discount);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 50;
        decimal discount = -10;
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] inputedNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int index = 3;
        int expected = 4;
        // Act
        int actual = _exceptions.IndexOutOfRangeGetElement(inputedNumbers, index);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] inputedNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int index = -3;
        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(inputedNumbers, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 20;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        bool logedIn = true;
        string expected = "User logged in.";
        // Act
        string result = _exceptions.InvalidOperationPerformSecureOperation(logedIn);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool logedIn = false;
        // Act & Assert
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(logedIn), Throws.InstanceOf<InvalidOperationException>());

    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string numberAsString = "5";
        int expected = 5;
        // Act
        int actual = _exceptions.FormatExceptionParseInt(numberAsString);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        string numberAsString = "ABV";
        int expected = 5;
        // Act & Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(numberAsString), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>();
        input.Add("text1", 1);
        input.Add("text2", 2);
        input.Add("text3", 3);
        string keySearched = "text2";
        int expected = 2;
        // Act
        int actual = _exceptions.KeyNotFoundFindValueByKey(input, keySearched);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>();
        input.Add("text1", 1);
        input.Add("text2", 2);
        input.Add("text3", 3);
        string keySearched = "text4";
        int expected = 4;
        // Act & Assert
        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(input, keySearched), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int a = 5;
        int b = 6;
        int expected = a + b;
        // Act
        int actual = _exceptions.OverflowAddNumbers(a, b);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MaxValue;
        int b = int.MaxValue;
        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());

    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MinValue;
        int b = int.MinValue;
        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());

    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int numberToDivide = 100;
        int divisior = 5;
        int expected = numberToDivide / divisior;
        // Act
        int actual = _exceptions.DivideByZeroDivideNumbers(numberToDivide, divisior);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int numberToDivide = 100;
        int divisior = 0;
        // Act & Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(numberToDivide, divisior), Throws.InstanceOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4 };
        int index = 2;
        int expected = 10;
        // Act
        int actual = _exceptions.SumCollectionElements(input, index);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[]? input = null;
        int index = 0;
        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(input, index), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[]? input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int index = 30;
        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(input, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        Dictionary<string, string> db = new Dictionary<string, string>();
        db.Add("a", "3");
        db.Add("c", "6");
        db.Add("d", "9");
        string key = "c";
        int expected = 6;
        // Act
        int actual = _exceptions.GetElementAsNumber(db, key);
        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, string> db = new Dictionary<string, string>();
        db.Add("a", "3");
        db.Add("c", "6");
        db.Add("d", "9");
        string key = "g";
        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(db, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        Dictionary<string, string> db = new Dictionary<string, string>();
        db.Add("a", "3");
        db.Add("c", "6");
        db.Add("d", "g");
        string key = "d";
        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(db, key), Throws.InstanceOf<FormatException>());
    }
}

