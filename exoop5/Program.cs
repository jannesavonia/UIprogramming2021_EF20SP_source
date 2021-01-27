using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoop5
{
    class Car
    {
        public static uint carCount = 0;
        public static List<Car> carList = new List<Car>();
        public Car()
        {
            Console.WriteLine("Car constructor");
            carCount++;
            carList.Add(this);
        }
        public decimal odometer
        {
            get;
            private set;
        }
        public void Drive(decimal kms)
        {
            if (kms < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(kms), "Don't try to decrease an odometer reading!");
            }
            odometer += kms;
        }
        public static void DriveAll(decimal kms)
        {
            foreach(var it in carList)
            {
                it.Drive(kms);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"There exists {Car.carCount} cars");

            Console.WriteLine("Create two cars");
            var c1 = new Car();
            var c2 = new Car();

            Console.WriteLine($"There exists {Car.carCount} cars");

            Console.WriteLine("Drive all cars 1000km");
            Car.DriveAll(1000);

            Console.WriteLine("Print odometer readings");
            Console.WriteLine(c1.odometer);
            Console.WriteLine(c2.odometer);
        }
    }
}
