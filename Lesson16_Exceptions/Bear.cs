using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Exceptions
{
    public class Bear
    {
        public string Type { get; set; }
        public bool IsSleeping { get; set; }


        public void GiveHoney(Honey honey)
        {
            if (honey.HoneyType == HoneyType.Buckwheat ||
                honey.HoneyType == HoneyType.Mustard ||
                !honey.IsFresh)
            {
                throw new BadHoneyException(honey);
            }

            if (IsSleeping)
            {
                throw new BearIsSleepingException(100);
            }

            Console.WriteLine($"The {Type} bear is enjoying the honey.");
        }
    }
}
