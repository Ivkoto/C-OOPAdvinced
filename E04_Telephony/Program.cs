using E04_Telephony.Models;
using System;

namespace E04_Telephony
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ');
            var sites = Console.ReadLine().Split(' ');

            ISmartphone phone = new Smartphone("Smartphone");

            foreach (var numb in numbers)
            {
                Console.WriteLine(phone.Call(numb)); 
            }

            foreach (var site in sites)
            {
                Console.WriteLine(phone.Browse(site));
            }
        }
    }
}