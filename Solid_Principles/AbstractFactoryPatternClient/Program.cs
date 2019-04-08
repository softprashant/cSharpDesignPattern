using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.HotDrinkFactory.API;

namespace AbstractFactoryPatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HotDrinkFactory.MakeDrink(HotDrinkTypes.Coffee).Serve();
        }
    }
}
