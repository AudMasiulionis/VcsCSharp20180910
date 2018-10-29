using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_EventsAndGenerics
{
    public interface IDataRetriever<T>
    {
        T Get();
        void Update(T value);
    }
}
