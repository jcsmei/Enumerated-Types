using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedTypes
{
    class Employee
    {
        public string Name { get; set; }
        public emPloyeeType TypeOfWork { get; set; }
        public Employee ( string n, emPloyeeType t)
        {
            Name = n;
            TypeOfWork = t;
        }
    }
}
