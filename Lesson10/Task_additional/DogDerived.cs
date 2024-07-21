using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_additional
{
    internal class DogDerived:FourLegAnimalDerived
    {
        public new void AnimalMove()
        {
            Console.WriteLine("Dog moves on four legs");
        }
    }
}
