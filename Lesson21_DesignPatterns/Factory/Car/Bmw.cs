namespace Lesson21_DesignPatterns.Factory.Car
{
    public class Bmw : ICar
    {
        public void Start()
        {
            System.Console.WriteLine("Bmw has started");
        }
    }
}