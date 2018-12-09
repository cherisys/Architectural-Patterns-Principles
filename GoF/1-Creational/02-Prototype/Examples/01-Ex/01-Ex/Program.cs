using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCar nanoBase = new Nano("Green Nano") { Price = 100000 };
            BasicCar fordBase = new Ford("Yellow Ford") { Price = 600000 };

            BasicCar bc1;
            bc1 = nanoBase.Clone();
            bc1.Price = nanoBase.Price + BasicCar.setPrice();
            Console.WriteLine("Car is: {0} and it's price is: {1}", bc1.ModelName, bc1.Price);

            bc1 = fordBase.Clone();
            bc1.Price = fordBase.Price + BasicCar.setPrice();
            Console.WriteLine("Car is: {0} and it's price is: {1}", bc1.ModelName, bc1.Price);

            Console.Read();
        }
    }
}
