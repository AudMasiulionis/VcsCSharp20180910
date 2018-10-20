using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Exceptions
{
    public class Honey
    {
        public HoneyType HoneyType { get; set; }
        public bool IsFresh { get; set; }

        public override string ToString()
        {
            return $"Honey:{nameof(HoneyType)} - {HoneyType} \n {nameof(IsFresh)} - {IsFresh}";
        }
    }
}
