using System;
namespace CarDrivingLibrary.API
{
    public interface ICar
    {
        void Drive();
    }

    public class CarDrive : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving the car!!");
        }
    }
    public class Driver
    {
        public int Age { get; set; }
    }

}
