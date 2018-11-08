using System;
using System.Threading;

namespace Lesson24_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Lambo", 200, 10, 1);
            var car2 = new Car("Lada", 250, 8, 2);
            var car3 = new Car("BMW", 180, 13, 1);

            var race = new Race(20000, new[] { car1, car2, car3 });
            race.StartRace();
        }

        private static void StartCar(Car car)
        {
            while (true)
            {
                Thread.Sleep(3 * 1000);
                car.Accelerate();
                Console.WriteLine(car.Speed);
            }
        }

        private static void Foo()
        {
            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine("Goodbye");
            }
        }
    }
}













//var car1 = new Car("Lambo", 200, 10, 1);
//var car2 = new Car("Lada", 250, 8, 2);
//var car3 = new Car("BMW", 180, 13, 1);

//var race = new Race(20000, new[] { car1, car2, car3 });
//race.StartRace();
