﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ex
{
    public abstract class BasicCar
    {
        public string ModelName { get; set; }
        public int Price { get; set; }
        public static int setPrice()
        {
            int price = 0;
            Random r = new Random();
            int p = r.Next(200000, 500000);
            price = p;
            return price;
        }

        public abstract BasicCar Clone();
    }
}
