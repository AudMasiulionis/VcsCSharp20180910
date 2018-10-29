using System;

namespace Lesson21_DesignPatterns.Strategy
{
    public class DroneShippingStrategy : IShippingCostStrategy
    {
        public decimal Calculate(Order order)
        {
            //additional logic here
            return 12;
        }
    }
}
