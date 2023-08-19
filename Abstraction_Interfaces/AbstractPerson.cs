using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interfaces
{
    abstract class AbstractPerson
    {
        public abstract uint Id { get; set; }
        public abstract string Name { get; set; }
    }

    class Student : AbstractPerson
    {
        uint id;
        string name;
        public override uint Id
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Id should be greater than zero.");
                }
                else
                {
                    id = value;
                }
            }
            get
            {
                return id;
            }

        }
        public override string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null or empty.");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }

        }
    }
}
