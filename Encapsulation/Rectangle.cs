using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public static class Rectangle
    {
        public static double length;
        public static double width;

        public static double GetArea()
        {
            return length * width;
        }

        public static void DisplayRectangle()
        {
            Console.WriteLine($"Length:\t{length}\n" +
                $"Width:\t{width}\n" +
                $"Area:\t{GetArea()}");
        }
    }
}
