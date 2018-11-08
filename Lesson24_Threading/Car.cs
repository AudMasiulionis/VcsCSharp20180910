namespace Lesson24_Threading
{
    public class Car
    {
        private int _acceleration;

        public Car(string name, int weight, int length, int height)
        {
            Name = name;
            Weight = weight;
            Length = length;
            Height = height;
        }

        public string Name { get; }
        public int Weight { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public double DistnaceDrove { get; private set; }

        public void Accelerate()
        {
            _acceleration++;
            DistnaceDrove += Speed;
        }

        public double Speed
        {
            get
            {
                return _acceleration * (0.23 * Weight * Length * Height);
            }
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Speed)}: {Speed}, {nameof(DistnaceDrove)}: {DistnaceDrove}, ";
        }
    }
}
