using System;

namespace PrinterAPI
{
    public class PrinterUtility // Bug in API as it should have been a static class as
                               // it is an application level functionality
    { 
        public void Print(string whatToPrint)
        {
            Console.WriteLine("Print :" + whatToPrint);
        }
    }
}
