namespace Lesson21_DesignPatterns.Strategy
{
    public class PigeonShippingStrategy : IShippingCostStrategy
    {
        public decimal Calculate(Order order)
        {
            //additional logic here
            return 2.35m;
        }
    }
}
