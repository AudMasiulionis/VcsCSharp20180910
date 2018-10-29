namespace Lesson21_DesignPatterns.Factory.Car
{
    public class Audi : ICar
    {
        public void Start()
        {
            System.Console.WriteLine("Audi has started");
        }
    }
}