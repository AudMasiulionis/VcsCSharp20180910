using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Exceptions
{
    class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string mesage) : base(mesage)
        {

        }
    }
}
