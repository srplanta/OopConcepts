using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interfaces
{
    interface IEmployee
    {
        //int id = 0;     //interface cannot contain instance fields/variables
        void ShowEmployee();
    }
}
