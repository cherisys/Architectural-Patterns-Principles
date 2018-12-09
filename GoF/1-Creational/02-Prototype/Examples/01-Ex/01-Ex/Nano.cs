using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ex
{
    public class Nano:BasicCar
    {
        public Nano(string mName)
        {
            ModelName = mName;
        }

        public override BasicCar Clone()
        {
            return (Nano)this.MemberwiseClone(); //shallow clone
        }
    }
}
