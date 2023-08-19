using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Square : Drawing
    {
        public double Length { get; set; }

        public Square()
        {
            Length = 6;
        }

        public Square(double length)
        {
            Length = length;
        }

        public override double Area()
        {
            return Math.Pow(Length, 2);
        }

        public override string ToString()
        {
            return $"Length:\t{Length}\n" +
                $"Area:\t{this.Area()}";
        }
    }
}
