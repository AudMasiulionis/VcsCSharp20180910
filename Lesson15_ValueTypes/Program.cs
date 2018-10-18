using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new ToDoItem();
            item.Start();
        }

        public static void PrintSize(Size size)
        {
            switch (size)
            {
                case Size.S:
                    Console.WriteLine("Small");
                    break;
                case Size.M:
                    Console.WriteLine("Medium");
                    break;
                case Size.L:
                    Console.WriteLine("Large");
                    break;
                case Size.XL:
                    Console.WriteLine("Extra - Large");
                    break;
            }
        }
    }
}
