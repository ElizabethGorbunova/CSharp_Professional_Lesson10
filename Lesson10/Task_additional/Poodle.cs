using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_additional
{
    internal class Poodle:DogDerived
    {
        public new void AnimalMove()
        {
            Console.WriteLine("Poodle moves on four legs");
        }
    }
}
