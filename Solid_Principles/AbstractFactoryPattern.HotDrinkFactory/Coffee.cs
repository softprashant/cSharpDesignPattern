using System;

namespace AbstractFactoryPattern.HotDrinkFactory.API
{
    internal class Coffee : IHotDrink
    {
        public Coffee()
        {
            Console.WriteLine("Preparing you the coffee..");
        }
        public void Serve()
        {
            Console.WriteLine("Serving you the coffee..");
        }
    }
}