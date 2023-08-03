using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interfaces
{
    class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle . . .");
        }
    }
}
