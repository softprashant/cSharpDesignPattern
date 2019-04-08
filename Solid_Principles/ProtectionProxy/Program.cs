using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDrivingLibrary.API;

namespace ProtectionProxy
{
    // Car > Person wants to drive the car 

    class Program
    {
        static void Main(string[] args)
        {
            CarDriveProxy carDriveProxy = new CarDriveProxy(new Driver
            {
                Age = 2
            });
            carDriveProxy.Drive();
        }
    }

    class CarDriveProxy : ICar
    {
        private readonly Driver _driver;
        private CarDrive _carDrive;
        public CarDriveProxy(Driver driver)
        {
            _driver = driver;
        }


        public void Drive()
        {
            if (_driver.Age >= 16)
            {
                _carDrive = new CarDrive();
                _carDrive.Drive();
            }
            else
            {
                Console.WriteLine("Can't drive under age");
            }
        }
    }
}
