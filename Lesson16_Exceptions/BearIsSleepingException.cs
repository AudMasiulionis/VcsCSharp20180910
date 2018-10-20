using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Exceptions
{
    public class BearIsSleepingException : Exception
    {
        public BearIsSleepingException(int roarDecibals) : base()
        {
            RoarDecibals = roarDecibals;
        }

        public BearIsSleepingException(int roarDecibals, string message) : base(message)
        {
            RoarDecibals = roarDecibals;
        }

        public BearIsSleepingException(int roarDecibals, string message, Exception innerException) : base(message, innerException)
        {
            RoarDecibals = roarDecibals;
        }

        public int RoarDecibals { get; }

        public override string Message
        {
            get
            {
                return $"Bear is roaring at {RoarDecibals} decibals. It is very angry. {base.Message}";
            }
        }
    }
}
