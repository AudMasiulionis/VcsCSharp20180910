using System.IO;
using System;
using System.Collections.Generic;
using Lesson15_ValueTypes;

namespace Lesson18_FilesAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Google("DBCABA"));
        }



        static string Google(string input)
        {
            char[] chars = input.ToCharArray();
            var temp = new Dictionary<char, int>();

            foreach (var c in chars)
            {
                if (temp.ContainsKey(c))
                {
                    return c.ToString();
                }
                temp.Add(c, 1);
            }

            return null;
        }
    }
}
