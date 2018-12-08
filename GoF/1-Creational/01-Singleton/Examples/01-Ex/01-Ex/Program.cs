using System;

namespace _01_Ex
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int noOfInstances = 0;

        //private constructor used to prevent instantiation using new keyword.
        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor.");
            noOfInstances++;
            Console.WriteLine("No. of instances: {0}", noOfInstances);
        }

        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now. Use it.");
                return instance;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trying to create instance s1.");
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Trying to create instance s2.");
            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
                Console.WriteLine("Single instance exists.");
            else
                Console.WriteLine("Multiple instances exists.");

            Console.Read();
        }
    }
}
