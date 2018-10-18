using Lesson15_ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lesson17_UnitTests_Tests
{
    [TestClass]
    public class TodoItemTests
    {
        [TestMethod]
        public void Start_ShouldSetCorrectState()
        {
            //arrange
            var todo = new ToDoItem();
            //act
            todo.Start();
            //assert
            Assert.AreEqual(Status.InProgress, todo.Status);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Start_TwoTimes_ShouldWhrowException()
        {
            //arrange
            var todo = new ToDoItem();
            //act
            todo.Start();
            todo.Start();
        }

    }
}
