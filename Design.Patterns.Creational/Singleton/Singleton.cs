namespace Design.Patterns.Creational.Singleton
{
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _Instance = new();

        public static Singleton Get =>
            _Instance;

        public void Message() =>
            Console.WriteLine(ToString());
    }
}
