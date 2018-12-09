using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ex
{
    //Product 
    class Product
    {
        private LinkedList<string> parts;

        public Product()
        {
            parts = new LinkedList<string>();
        }

        public void Add(string part)
        {
            parts.AddLast(part);
        }

        public void Show()
        {
            Console.WriteLine("\n\nProduct completed as below:");
            foreach (string part in parts)
                Console.WriteLine("\n{0}", part);
        }
    }

    //Builders common interface
    interface IBuilder
    {
        void AddHeadlights();
        void BuildBody();
        void EndOperations();
        void InsertWheels();
        void StartupOperations();
        Product GetVehicle();
    }

    //Concrete Builder for Car
    class Car : IBuilder
    {
        private string BrandName;
        private Product product;
        public Car(string brandName)
        {
            product = new Product();
            this.BrandName = brandName;
        }
        public void StartupOperations()
        {
            product.Add(string.Format("Car Model Name: {0}", this.BrandName));
        }
        public void BuildBody()
        {
            product.Add("This is a body of a car.");
        }
        public void InsertWheels()
        {
            product.Add("4 wheels added.");
        }
        public void AddHeadlights()
        {
            product.Add("2 headlights added.");
        }
        public void EndOperations()
        {
            //nothing in this case.
        }
        public Product GetVehicle()
        {
            return product;
        }
    }

    //Concrete Builder for Motorcycle
    class Motorcycle : IBuilder
    {
        private string BrandName;
        private Product product;
        public Motorcycle(string brandName)
        {
            product = new Product();
            this.BrandName = brandName;
        }
        public void StartupOperations()
        {
            //nothing in this case.
        }
        public void BuildBody()
        {
            product.Add("This is a body of a motorcycle.");
        }
        public void InsertWheels()
        {
            product.Add("2 wheels added.");
        }
        public void AddHeadlights()
        {
            product.Add("1 headlights added.");
        }
        public void EndOperations()
        {
            product.Add(string.Format("Motorcycle model name: {0}", this.BrandName));
        }
        public Product GetVehicle()
        {
            return product;
        }
    }

    //Director
    class Director
    {
        IBuilder Builder;
        public void Construct(IBuilder builder)
        {
            this.Builder = builder;
            builder.StartupOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Director d = new Director();

            IBuilder b1 = new Car("Ford");
            IBuilder b2 = new Motorcycle("Honda");

            //Making car
            d.Construct(b1);
            Product p1 = b1.GetVehicle();
            p1.Show();

            //Making motorcycle
            d.Construct(b2);
            Product p2 = b2.GetVehicle();
            p2.Show();

            Console.Read();
        }
    }
}
