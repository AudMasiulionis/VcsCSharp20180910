using Lesson15_ValueTypes;
using Lesson19_EventsAndGenerics.Generics;
using System.Collections.Generic;
using System.Linq;

#pragma warning disable
namespace Lesson19_EventsAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var gen = new MyGeneric<ToDoItem>();

            var genericList = new List<string>();

            var genericDict = new Dictionary<int, string>();
        }
    }
}
