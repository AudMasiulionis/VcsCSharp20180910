using Lesson15_ValueTypes;
using System;
using System.Collections.Generic;

namespace Lesson17_UnitTests
{
    public class ToDoList
    {
        //todo add field and expose threw ReadOnlyList
        public List<ToDoItem> Items = new List<ToDoItem>();

        public void AddTodoItem(ToDoItem toDoItem)
        {
            if (toDoItem == null)
            {
                throw new ArgumentNullException(nameof(toDoItem));
            }

            if (GetItemCount(Status.Todo) == 10)
            {
                throw new Exception("Cannot add any more items.");
            }

            Items.Add(toDoItem);
        }

        public void StartTodo(Guid itemId)
        {
            var item = FindById(itemId);
            if (item == null)
            {
                throw new InvalidOperationException($"Item with Id:[{item} cannot be found!]");
            }

            if (GetItemCount(Status.InProgress) == 3)
            {
                throw new Exception("Cannot start this todo");
            }

            item.Start();
        }

        //todo refactor with LINQ
        public int GetItemCount(Status status)
        {
            var count = 0;
            foreach (var item in Items)
            {
                if (item.Status == status)
                {
                    count++;
                }
            }
            return count;
        }

        //todo refactor with LINQ
        private ToDoItem FindById(Guid id)
        {
            foreach (var item in Items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
