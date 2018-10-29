using Lesson15_ValueTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson20_LINQ
{
    class Program
    {
        private static ToDoItem list;

        static void Main(string[] args)
        {
            var a = new List<int> { 1, 2, 3 };

            var aa = a.Select(i => i * i);
        }
    }
}
