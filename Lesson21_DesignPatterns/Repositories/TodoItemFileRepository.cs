using System.Collections.Generic;
using Lesson15_ValueTypes;

namespace Lesson21_DesignPatterns.Repositories
{
    public class TodoItemFileRepository : IRepository<ToDoItem>
    {
        public void Add(ToDoItem item)
        {
            throw new System.NotImplementedException();
        }

        //todo add logic to use items from file

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ToDoItem Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ToDoItem> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(ToDoItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}
