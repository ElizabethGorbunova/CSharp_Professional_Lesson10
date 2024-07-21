using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_additional
{
    public class AnimalBase
    {

        public void Move()
        {
            AnimalMove();
        }

        public virtual void AnimalMove()
        {
            Console.WriteLine("Animal moves");
        }
    }
}
