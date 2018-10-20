using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_ValueTypes
{
    public class ToDoItem
    {
        public ToDoItem()
        {
            Id = Guid.NewGuid();
            CreationTime = DateTime.Now;
        }

        public ToDoItem(string name) : this()
        {
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; private set; }
        public DateTime CreationTime { get; }
        public DateTime? FinishedTime { get; private set; }

        public void Start()
        {
            if (Status != Status.Todo)
            {
                throw new Exception("Item cannot be started");
            }

            Status = Status.InProgress;
        }

        public void Finish()
        {
            if (Status != Status.InProgress)
            {
                throw new Exception("Item cannot be started");
            }

            Status = Status.Done;
            FinishedTime = DateTime.Now;
        }
    }
}
