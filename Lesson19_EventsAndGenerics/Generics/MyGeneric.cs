using System;

namespace Lesson19_EventsAndGenerics.Generics
{
    public class MyGeneric<T>
    {
        public void GetT(T value)
        {
            Console.WriteLine(value);
        }
    }

    public class MyGenericWithClassConstraint<T> where T : class
    {
        public string Get(T value)
        {
            return value.ToString();
        }
    }

    public class MyGenericWithClassConstraint1<T> where T : struct
    {
        public string Get(T value)
        {
            return value.ToString();
        }
    }

    public class MyGenericWithClassConstraint2<T> where T : ICloneable
    {
        public string Get(T value)
        {
            return value.ToString();
        }
    }

    public class MyGenericWithClassConstraint3<T> where T : new()
    {
        public string Get(T value)
        {
            return value.ToString();
        }
    }

    public class MyGenericWithClassConstraint4<T> where T : SomeBaseClass
    {
        public string Get(T value)
        {
            return value.ToString();
        }
    }

    public class MyGenericWithClassConstraint5<T, K>
        where T : class
        where K : class
    {
        public string Get(T value)
        {
            return value.ToString();
        }
    }
}
