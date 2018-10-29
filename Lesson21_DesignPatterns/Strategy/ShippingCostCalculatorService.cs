namespace Lesson21_DesignPatterns.Strategy
{
    public class ShippingCostCalculatorService
    {
        private readonly IShippingCostStrategy _costStrategy;

        public ShippingCostCalculatorService(IShippingCostStrategy costStrategy)
        {
            _costStrategy = costStrategy;
        }

        public decimal Calculate(Order order)
        {
            return order.Price + _costStrategy.Calculate(order);
        }
    }
}
