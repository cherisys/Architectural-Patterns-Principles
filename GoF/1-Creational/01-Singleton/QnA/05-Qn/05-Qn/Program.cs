using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Qn
{
    //without sealed keyword.
    public class Singleton
    {
        private int noOfInstances = 0;

        private Singleton()
        {
            Console.WriteLine("Instantiating class in constructor.");
            noOfInstances++;
            Console.WriteLine("No. of instances: {0}", noOfInstances);
        }

        public static Singleton Instance { get; } = new Singleton();

        //keyword sealed can guared this scenario
        public class NestedDerived : Singleton { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.NestedDerived nd1 = new Singleton.NestedDerived();
            Singleton.NestedDerived nd2 = new Singleton.NestedDerived();
            //When NestedDerived class is instantiated 
            //Each time a separate instance of Parent Class (Singleton) is created.
            //This could be prevented by making the Singleton class a sealed class.
            Console.Read();
        }
    }
}
