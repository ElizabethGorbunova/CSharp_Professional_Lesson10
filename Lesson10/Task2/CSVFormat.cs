using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class CSVFormat:FileSaver
    {
        public CSVFormat() : base("csv")
        {
        }

        public override void SaveAsCSV()
        {
            Console.WriteLine("Saving file as CSV...");
        }
    }
}
