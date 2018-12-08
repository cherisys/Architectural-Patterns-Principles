using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Qn
{
    public class Singleton
    {
        private static Singleton instance;
        private Singleton() {
            Console.WriteLine("Creating instance in constructor.");
        }

        public static Singleton Instance
        {
            get
            {
                //this approach will work fine in single threaded environment.
                //in multithreaded environment if-condition will be true, once for each thread.
                //in multithreaded environment it will result creating multiple objects.
                if(instance == null)
                {
                    instance = new Singleton();
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
                Console.WriteLine("Multiple instances instance exists.");

            Console.Read();
        }
    }
}
