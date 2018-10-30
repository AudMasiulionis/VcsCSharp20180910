#pragma warning disable

using Lesson15_ValueTypes;
using System;
using System.Linq;

namespace Lesson22_HTTP
{
    class Program
    {
        public static void Main()
        {
            var client = new BeerClient();
            var beers = client.GetBeers();

            foreach (var item in beers.OrderBy(b => b.Price))
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
