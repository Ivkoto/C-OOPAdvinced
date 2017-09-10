using System;
using System.Collections.Generic;

namespace E03_GenericBoxIntegers
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            List<IBox<int>> List = new List<IBox<int>>();
            for (int i = 0; i < n; i++)
            {
                var integer = int.Parse(Console.ReadLine());
                List.Add(new Box<int>(integer));
            }

            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
        }
    }
}