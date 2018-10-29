namespace Lesson21_DesignPatterns.Factory.Car
{
    internal class Lada : ICar
    {
        public void Start()
        {
            System.Console.WriteLine("Lada won't start..");
        }
    }
}