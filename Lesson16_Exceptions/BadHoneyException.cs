using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Exceptions
{
    class BadHoneyException : Exception
    {
        public BadHoneyException(Honey honey) : base()
        {
            Honey = honey;
        }

        public BadHoneyException(Honey honey, string message) : base(message)
        {
            Honey = honey;
        }

        public BadHoneyException(Honey honey, string message, Exception innerException) : base(message, innerException)
        {
            Honey = honey;
        }

        public Honey Honey { get; }

        public override string Message
        {
            get
            {
                return $"Bear doesn't like { Honey.ToString() }";
            }
        }
    }
}
