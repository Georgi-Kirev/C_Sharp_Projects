using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{
    // TODO: write the setup method

    // TODO: finish test
    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        Person newPerson = new Person();
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
        List<Person> expectedPeopleList = new List<Person>
        {
            new Person { Name = "Alice", Id = "A001", Age = 35 },
            new Person { Name = "Bob", Id = "B002", Age = 30 }
        };
        // Act
        List<Person> resultPeopleList = newPerson.AddPeople(peopleData);

        // Assert
        Assert.That(resultPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < resultPeopleList.Count; i++)
        {
            Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        Person newPerson = new Person();
        string[] peopleData = { "Alice A001 25", "Michael A003 35", "Bob B002 30" };

        string expected = $"Alice with ID: A001 is 25 years old.{Environment.NewLine}" +
                          $"Bob with ID: B002 is 30 years old.{Environment.NewLine}" +
                          $"Michael with ID: A003 is 35 years old.";
        // Act
        List<Person> resultPeopleList = newPerson.AddPeople(peopleData);
        string sortedList = newPerson.GetByAgeAscending(resultPeopleList);
        // Assert
        Assert.AreEqual(expected, sortedList);
    }

    [Test]
    public void Test_GetByAgeAscending_ReturnsPeopleSortedByAge2()
    {
        // Arrange
        Person newPerson = new Person();
        string[] peopleData = { "Charlie C003 40", "Alice A001 25", "Bob B002 30" };

        // Очакваме сортиран резултат по възраст: 25, 30, 40
        string expected =
            $"Alice with ID: A001 is 25 years old.{Environment.NewLine}" +
            $"Bob with ID: B002 is 30 years old.{Environment.NewLine}" +
            $"Charlie with ID: C003 is 40 years old.";

        // Act
        List<Person> resultPeopleList = newPerson.AddPeople(peopleData);
        string sortedList = newPerson.GetByAgeAscending(resultPeopleList);

        // Assert
        Assert.AreEqual(expected, sortedList);
    }
}
