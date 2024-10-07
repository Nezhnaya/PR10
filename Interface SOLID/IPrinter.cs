using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface_SOLID
{
    // Interface Segregation Principle (ISP)
    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();
    }

    public class MultifunctionalDevice : IPrinter, IScanner
    {
        public void Print()
        {
            Console.WriteLine("Printing a document");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning a document");
        }
    }

    public class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing a document");
        }
    }

    public class Scanner : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scanning a document");
        }
    }
}
