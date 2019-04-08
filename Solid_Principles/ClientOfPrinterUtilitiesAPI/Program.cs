using System;
using System.ComponentModel;
using PrinterAPI;

namespace ClientOfPrinterUtilitiesAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer.Instance.Print("Printing : first time");
            Printer.Instance.Print("Printing : second time");
            Console.ReadKey();
            // I need to make the class singleton since I want to use only one instance
        }
    }

    public class Printer : PrinterUtility
    {
        public static readonly Printer Instance;

        static Printer()
        {
            Instance = new Printer();
        }
        private Printer()
        {

        }
    }
}
