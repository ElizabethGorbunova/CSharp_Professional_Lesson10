using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class FileSaver
    {
        private readonly string format;
        public string Format { get; set; }

        public FileSaver(string format)
        {
            this.format = format;
        }
        public void SaveFile()
        {
            PreparingForSaving();

            switch (format)
            {
                case "pdf":
                     SaveAsPDF();
                    break;
                case "word":
                     SaveAsWord();
                    break;
                case "csv":
                     SaveAsCSV();
                    break;
            }

            ClosingSaving();

        }

        private void PreparingForSaving()
        {
            Console.WriteLine("Invoke saving program...");
            Console.WriteLine("Ask for a path of a document...");
            Console.WriteLine("Check the access...");
        }

        public virtual void SaveAsCSV() { }
        public virtual void SaveAsWord() { }
        public virtual void SaveAsPDF() { }

        private void ClosingSaving()
        {
            Console.WriteLine($"Saving file in {format}...");
            Console.WriteLine("Closing saver program...");
        }
    }
}
