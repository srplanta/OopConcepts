using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interfaces
{
    class PartTimeEmployee : IEmployee
    {
        public void ShowEmployee()
        {
            Console.WriteLine("ShowEmployee() method of IEmployee is implemented in PartTimeEmployee Class!");
        }
    }
}
