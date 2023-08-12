using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Rectangle
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
            }
        }
        public double GetArea()
        {
            return length * width;
        }

        public void DisplayRectangle()
        {
            Console.WriteLine($"Length:\t{Length}\n" +
                $"Width:\t{Width}\n" +
                $"Area:\t{GetArea()}");
        }
    }
}
