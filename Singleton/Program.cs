using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = new Singleton();
            Singleton anotherSingleton = new Singleton();
            Console.WriteLine("Is singleton? " + (singleton == anotherSingleton));
        }
    }
}
