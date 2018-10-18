using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_ValueTypes
{
    public class Point
    {
        public int? X { get; set; }
        public int X1 { get; set; }
        public int? Y { get; set; }


        public override string ToString()
        {
            return $"X: {X} Y:{Y}";
        }

    }
}
