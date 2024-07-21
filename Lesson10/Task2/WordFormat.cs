using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class WordFormat:FileSaver
    {
        public WordFormat() : base("word")
        {
        }

        public override void SaveAsWord()
        {
            Console.WriteLine("Saving File as Word...");
        }
    }
}
