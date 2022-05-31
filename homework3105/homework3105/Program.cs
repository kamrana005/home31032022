using System;

namespace homework3105
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("AddFuel:");
            string fuelstr = Console.ReadLine();
            double fuel = Convert.ToDouble(fuelstr);
            if (FuelCapacity >= fuel)
            {

            }

            Car car = new Car
            {
                Brand = "BMW",
                Model = "X5",

                Mileage = 16740,
                FuelCapacity = 87
            };
            
            













        }
    }
}
