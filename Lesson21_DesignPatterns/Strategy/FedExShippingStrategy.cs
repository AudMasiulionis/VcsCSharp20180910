using System;

namespace Lesson21_DesignPatterns.Strategy
{
    public class FedExShippingStrategy : IShippingCostStrategy
    {
        public decimal Calculate(Order order)
        {
            //additional logic here
            return 6.35m;
        }
    }
}
