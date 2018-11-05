using System;
using System.Data.SqlClient;
#pragma warning disable

namespace Lesson23_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonRepository();

            var p = r.Get(1);
            p.Age = 9999999;
            r.Update(p);
        }
    }
}
