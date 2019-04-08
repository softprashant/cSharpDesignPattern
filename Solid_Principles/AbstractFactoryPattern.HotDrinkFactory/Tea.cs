using System;

namespace AbstractFactoryPattern.HotDrinkFactory.API
{
    internal class Tea : IHotDrink
    {
        public Tea()
        {
            Console.WriteLine("Preparing you the Tea..");
        }
        public void Serve()
        {
            Console.WriteLine("Serving you the Tea..");
        }
    }
}