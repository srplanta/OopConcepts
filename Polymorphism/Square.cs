﻿using System;
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

        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }
}
