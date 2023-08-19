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
                id = value;
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
                name = value;
            }
            get
            {
                return name;
            }

        }
    }
}
