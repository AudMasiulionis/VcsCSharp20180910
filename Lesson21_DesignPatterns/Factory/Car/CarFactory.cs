namespace Lesson21_DesignPatterns.Factory.Car
{
    public static class CarFactory
    {
        public static ICar CreateCar(string carType)
        {
            switch (carType)
            {
                case "bmw":
                    return new Bmw();
                case "audi":
                    return new Audi();
                case "lada":
                    return new Lada();
                default:
                    return null;
            }
        }
    }
}
