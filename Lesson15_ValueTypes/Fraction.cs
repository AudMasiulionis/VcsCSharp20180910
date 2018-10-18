using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_ValueTypes
{
    public class Fraction
    {
        public decimal Numerator { get; set; }
        public decimal Denominator { get; set; }

        public Fraction(decimal numerator, decimal denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public decimal Value()
        {
            return Numerator / Denominator;
        }
    }
}
