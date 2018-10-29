using Lesson21_DesignPatterns.Factory.Car;
using Lesson21_DesignPatterns.Strategy;

namespace Lesson21_DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ShippingCostCalculatorService(new FakePriceStrategy());
            System.Console.WriteLine(service.Calculate(new Order() { Price = 1 }));
        }
    }
}
