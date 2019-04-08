using System;

namespace AbstractFactoryPattern.HotDrinkFactory.API
{
    public enum HotDrinkTypes // PLEASE NOTE THAT THIS VIOLATES THE OPEN CLOSED PRINCIPLE AS THE INPUT SHOULD BE TAKEN FROM THE USER AS A STRING. the current approach is ok if you are sure that only 2 type of drinks will be there but if one more comes then you have change the enyum
    {
        Coffee, Tea
    }
    public static class HotDrinkFactory
    {
        public static IHotDrink MakeDrink(HotDrinkTypes type)
        {
            // NOTE : BETTER TO USE REFLECTION AS YOU HAVE HARDCODED THE CLASSES TO THAT THIS CLASS
            //BECOME OPEN TO EXTENSION  TO FULL FILL OCP 
            switch (type)
            {
                case HotDrinkTypes.Coffee:
                    return new Coffee(); // You can further make the factory of coffee , this is optional
                case HotDrinkTypes.Tea:
                    return new Tea();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
