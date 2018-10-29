using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_EventsAndGenerics
{
    public static class Mapper
    {

        public static Gender MapIntToGender(int value)
        {
            Gender result;
            return (Gender)value;
        }

        public static Gender MapStringToGender(string value)
        {
            Gender result;
            if (!Enum.TryParse(value, out result))
            {
                throw new Exception($"Value '{value}' is not part of Gender enum");
            }

            return result;
        }

        public static Weekday MapStringToWeekday(string value)
        {
            Weekday result;
            if (!Enum.TryParse(value, out result))
            {
                throw new Exception($"Value '{value}' is not part of Weekday enum");
            }

            return result;
        }

    }
}
