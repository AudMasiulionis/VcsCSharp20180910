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


            r.Add(new Person
            {
                Age = 12,
                FirtName = "123",
                LastName = "222"
            });


        }
    }
}
