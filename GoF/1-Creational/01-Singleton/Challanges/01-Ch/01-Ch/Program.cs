using System;

namespace _01_Ch
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int noOfInstance = 0;

        private Singleton()
        {
            Console.WriteLine("Instantiating inside constructor.");
            noOfInstance++;
            Console.WriteLine("No. of instances: {0}", noOfInstance);
        }

        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("Instance exists. Use it.");
                return instance;
            }
        }

        public static int MyInt = 25;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.MyInt);
            //Here using static variable MyInt created an instance of Singleton class.
            //Without calling Instance property.
            //Depicts there is less control over instantiation process.
            Console.Read();
        }
    }
}
