using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoop5
{
    class Car
    {
        public decimal odometer
        {
            get;
            private set;
        }
        public void Drive(decimal kms)
        {
            if(kms<0)
            {
                throw new ArgumentOutOfRangeException(nameof(kms), "Don't try to decrease an odometer reading!");
            }
            odometer += kms;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int Ncars = 10;
            var carList = new List<Car>();

            for(int i=0; i<Ncars; i++)
            {
                carList.Add(new Car());
            }

            /*
            //Drive 1000 kms
            foreach(var it in carList)
            {
                it.Drive(1000);
            }
            */

            //Drive random amount
            var rnd = new Random();
            foreach (var it in carList)
            {
                try
                {
                    it.Drive(rnd.Next(-100, 500));
                } catch(ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            foreach (var it in carList)
            {
                Console.WriteLine(it.odometer);
            }

        }
    }
}
