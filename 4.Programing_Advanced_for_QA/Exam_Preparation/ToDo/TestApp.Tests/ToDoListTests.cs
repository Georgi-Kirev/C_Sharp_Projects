using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;

    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!   Локално на компютара ми дава греша понеже на датите изисква месец година
    // да са с точка 04.16.2026 а те а Джъдж ги изисква с наклонена черта: 04/16/2026
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        _toDoList.AddTask("To wash my Car!", DateTime.Now);

        string expected = "To-Do List:" + Environment.NewLine +
                          "[ ] To wash my Car! - Due: 04/16/2026";
        // Act
        string actual = _toDoList.DisplayTasks();
        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        _toDoList.AddTask("To wash my Car!", DateTime.Now);

        string expected = "To-Do List:" + Environment.NewLine +
                          "[✓] To wash my Car! - Due: 04/16/2026";
        // Act
        _toDoList.CompleteTask("To wash my Car!");
        string actual = _toDoList.DisplayTasks();
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        _toDoList.AddTask("To wash my Car!", DateTime.Now);

        string expected = "To-Do List:" + Environment.NewLine +
                          "[ ] To wash my Car! - Due: 04/16/2026";
        // Act & Assert
        Assert.That(() => _toDoList.CompleteTask("To go to the Gym."), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange
        string expected = "To-Do List:";
        // Act
        string actual = _toDoList.DisplayTasks();
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        _toDoList.AddTask("To wash my Car!", DateTime.Now);
        _toDoList.AddTask("To go to the Gym.", DateTime.Now);
        _toDoList.AddTask("To go Shopping", DateTime.Now);

        _toDoList.CompleteTask("To go Shopping");

        string expected = "To-Do List:" + Environment.NewLine +
                          "[ ] To wash my Car! - Due: 04/16/2026" + Environment.NewLine +
                          "[ ] To go to the Gym. - Due: 04/16/2026" + Environment.NewLine +
                          "[✓] To go Shopping - Due: 04/16/2026";
        // Act
        string actual = _toDoList.DisplayTasks();
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
