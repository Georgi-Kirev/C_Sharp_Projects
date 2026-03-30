using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Tests
{
    public class VowelsCounterTests
    {
        [Test]
        public void Test_CountTotalVowels_GetEmptyList_ReturnsZero()
        {
            // Arrange
            List<string> strings = new List<string>();
            // Act
            int actual = VowelsCounter.CountTotalVowels(strings);
            // Assert
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void Test_CountTotalVowels_GetListWithEmptyStringValues_ReturnsZero()
        {
            // Arrange
            List<string> strings = new List<string>() { "", "", "", "" };
            // Act
            int actual = VowelsCounter.CountTotalVowels(strings);
            // Assert
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void Test_CountTotalVowels_MultipleLowerCaseStrings_ReturnsVowelsCount()
        {
            // Arrange
            List<string> strings = new List<string>() { "banana", "kiwi", "tomato", "onion" };
            int expected = 11;
            // Act
            int actual = VowelsCounter.CountTotalVowels(strings);
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalVowels_GetStringsWithNoVowels_ReturnsZero()
        {
            // Arrange
            List<string> strings = new List<string>() { "blk", "kdkd", "slv", "mnbvc" };
            int expected = 0;
            // Act
            int actual = VowelsCounter.CountTotalVowels(strings);
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalVowels_StringsWithMixedCaseVowels_ReturnsVowelsCount()
        {
            // Arrange
            List<string> strings = new List<string>() { "Bmw", "OpEl", "VolVo", "Mini" };
            int expected = 6;
            // Act
            int actual = VowelsCounter.CountTotalVowels(strings);
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
