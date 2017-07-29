using E03_Ferrari.Models;
using System;

namespace E03_Ferrari
{
    public class Program
    {
        public static void Main()
        {
            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;
            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }

            var driverName = Console.ReadLine();
            ICar ferrari = new Ferrari(driverName);

            Console.WriteLine($"{ferrari.Model}/{ferrari.UseBreaks()}/{ferrari.PushTheGasPedal()}/{ferrari.Driver}");
        }
    }
}