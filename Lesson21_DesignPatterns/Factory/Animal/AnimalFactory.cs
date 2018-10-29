namespace Lesson21_DesignPatterns.Factory.Animal
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(AnimalType animalType)
        {
            switch (animalType)
            {
                case AnimalType.Bird:
                    return new Bird();
                case AnimalType.Mammal:
                    return new Mammal();
                case AnimalType.Reptile:
                    return new Reptile();
                default:
                    return null;
            }
        }
    }
}
