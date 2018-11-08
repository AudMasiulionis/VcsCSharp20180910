using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Lesson24_Threading
{
    public class Race
    {
        private readonly double _raceLenth;
        private readonly IEnumerable<Car> _cars;

        public Race(double raceLength, IEnumerable<Car> cars)
        {
            _raceLenth = raceLength;
            _cars = cars;
        }

        public void StartRace()
        {
            var threads = _cars.Select(c => new Thread(() => DoRace(c)));
            foreach (var t in threads)
            {
                t.Start();
            }
        }

        private void DoRace(Car car)
        {
            while (car.DistnaceDrove <= _raceLenth)
            {
                Thread.Sleep(1 * 1000);
                car.Accelerate();
                Console.WriteLine(car);
            }

            Console.WriteLine($"{car.Name} has finished the race");
        }
    }
}
