namespace Lesson21_DesignPatterns.Singletons
{
    public sealed class Singleton
    {
        private static Singleton _instance;

        private Singleton() { }

        public static Singleton Instace
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}
