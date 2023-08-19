using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class OperatorOverloading
    {
        public string Name { get; set; }
        public int Fee { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\tFee: {Fee}";
        }

        public static OperatorOverloading operator +(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading obj3 = new OperatorOverloading();
            obj3.Name = obj1.Name + " " + obj2.Name;
            obj3.Fee = obj1.Fee + obj2.Fee;
            return obj3;
        }
    }
}
