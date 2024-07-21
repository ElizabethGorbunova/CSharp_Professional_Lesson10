using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_additional
{
    internal class FourLegAnimalDerived:AnimalBase 
    {
        public new void AnimalMove()     //if class inherits base class with virtual method, then method AnimalMove won't be closed in current class
        {
            Console.WriteLine("Animal moves on four legs");
        }
    }
}
