using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Circle : Drawing
    {
        public double Radious { get; set; }
        public Circle()
        {
            Radious = 5;
        }

        public Circle(double radious)
        {
            Radious = radious;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radious, 2);
        }

        public override string ToString()
        {
            return $"Radious:\t{Radious}\n" +
                $"Area:\t{this.Area()}";
        }
    }
}
