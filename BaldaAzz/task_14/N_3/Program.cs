using System;

namespace N_3
{
    class MyInfo
    {
        public event Action<string>? notify;

        private string name;

        public MyInfo(string name)
        {
            this.name = name;
        }
        
        public void ChangeName(string otherName)
        {
            this.name = otherName;
            notify(otherName);
        }
    }

    class Handler
    {
        public void DisplayMessage(string name) => Console.WriteLine($"Произошло изменение имени на {name}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyInfo person = new("Дмитрий");
            Handler handler = new();

            person.notify += handler.DisplayMessage;

            person.ChangeName("Mike");
            person.ChangeName("Adidas");
            person.ChangeName("Олег");
        }
    }
}