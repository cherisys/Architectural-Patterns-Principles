using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ex
{
    public class Ford: BasicCar 
    {
        public Ford(string mName)
        {
            ModelName = mName;
        }

        public override BasicCar Clone()
        {
            return (Ford)this.MemberwiseClone();
        }
    }
}
