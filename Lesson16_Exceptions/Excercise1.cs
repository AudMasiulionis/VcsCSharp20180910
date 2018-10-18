using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Exceptions
{
    class Excercise1
    {
        public static void GetArrayItem(int[] array, int index)
        {
            try
            {
                var a = array[index];
            }
            catch (Exception)
            {
                Console.WriteLine("Array item out of bounds");
            }
        }
    }
}
