namespace Lesson21_DesignPatterns.Strategy
{
    public interface IShippingCostStrategy
    {
        decimal Calculate(Order order);
    }
}
