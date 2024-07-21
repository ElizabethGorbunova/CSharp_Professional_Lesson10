using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class PDFFormat:FileSaver
    {
        public PDFFormat() : base("pdf")
        {
        }

        public override void SaveAsPDF()
        {
            Console.WriteLine("Saving file as PDF...");
        }
    }
}
