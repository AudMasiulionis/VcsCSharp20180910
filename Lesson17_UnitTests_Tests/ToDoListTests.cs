using Lesson15_ValueTypes;
using Lesson17_UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lesson17_UnitTests_Tests
{
    [TestClass]
    public class ToDoListTests
    {
        [TestMethod]
        public void ShouldCreateEmptyItemList()
        {
            var list = new ToDoList();
            Assert.AreEqual(0, list.Items.Count);
        }

        [TestMethod]
        public void AddTodoItem_ShouldAddListItem()
        {
            var list = new ToDoList();
            var item = new ToDoItem("Item");

            list.AddTodoItem(item);

            Assert.AreEqual(1, list.Items.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddTodoItem_ShouldThrowWithNullParameter()
        {
            var list = new ToDoList();
            list.AddTodoItem(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddTodoItem_ShouldThrowMoreThan10Items()
        {
            var list = new ToDoList();

            for (int i = 0; i < 10; i++)
            {
                list.AddTodoItem(new ToDoItem());
            }

            list.AddTodoItem(new ToDoItem());
        }

        [TestMethod]
        public void StartTodo_ShouldChangeItemsStatus()
        {
            var list = new ToDoList();
            list.AddTodoItem(new ToDoItem());

            list.StartTodo(list.Items[0].Id);
            Assert.AreEqual(1, list.GetItemCount(Status.InProgress));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StartTodo_ShouldThrowExceptionWhenMoreThan3Inpreogress()
        {
            var list = new ToDoList();
            list.AddTodoItem(new ToDoItem());
            list.AddTodoItem(new ToDoItem());
            list.AddTodoItem(new ToDoItem());
            list.AddTodoItem(new ToDoItem());
            list.StartTodo(list.Items[0].Id);
            list.StartTodo(list.Items[1].Id);
            list.StartTodo(list.Items[2].Id);

            list.StartTodo(list.Items[3].Id);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StartTodo_ShouldThrowWhenStartingNotExisting()
        {
            var list = new ToDoList();
            list.StartTodo(Guid.NewGuid());
        }
    }
}
