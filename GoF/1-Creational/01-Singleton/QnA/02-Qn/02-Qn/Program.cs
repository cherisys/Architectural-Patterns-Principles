using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Qn
{
    public sealed class Singleton
    {
        //using volatile to ensure that
        //assignment to instance variable finishes before it's access.
        private static volatile Singleton instance;
        private static object lockObject = new object();

        private Singleton() {
            Console.WriteLine("Creating instance in constructor.");
        }

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    //this approach will help to create an instance when it's really needed.
                    //but locking mechanism is expensive in complexity.
                    lock (lockObject)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
                Console.WriteLine("Only one instance exists.");
            else
                Console.WriteLine("Multiple instances exist.");

            Console.Read();
        }
    }
}
