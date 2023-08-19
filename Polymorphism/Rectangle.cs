using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rectangle : Drawing
    {
        public double Length { get; set; }
        public double Bredth { get; set; }
        public Rectangle()
        {
            Length = 5.3;
            Bredth = 3.4;
        }

        public Rectangle(double length, double bredth)
        {
            Length = length;
            Bredth = bredth;
        }

        public override double Area()
        {
            return Length * Bredth;
        }

        public override string ToString()
        {
            return $"Length:\t{Length}\n" +
                $"Bredth:\t{Bredth}\n" +
                $"Area:\t{this.Area()}";
        }
    }
}
