using System;

namespace N_4
{
    class Meteorite
    {
        public delegate void MethodContainer();
        public event Action WhenFall = delegate{};

        // Чтобы небыло исключения, если не будет ссылки хотябы на один метод
        // public Meteorite() => WhenFall = () => {};

        public void FallToEarth()
        {   
            WhenFall();
            Console.WriteLine("Метиорит упал на землю");
        }
    }

    class God
    {
        public void Say() => Console.WriteLine("Бог сказал: Ахахах");
    }

    class Dinosaur
    {
        public void Say() => Console.WriteLine("Динозавр прокричал: О нет! Мы все умрём!!!");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Meteorite meteorite = new();
            God god = new();
            Dinosaur Anton = new();

            meteorite.WhenFall += god.Say;
            meteorite.WhenFall += Anton.Say;
            meteorite.FallToEarth();

            meteorite.WhenFall -= god.Say;
            meteorite.FallToEarth();
        }
    }
}