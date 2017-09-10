using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace E01_GenericBoxString
{
    public class Program
    {
        public static void Main()
        {

            List<IBox<string>> list = new List<IBox<string>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(new Box<string>(Console.ReadLine()));
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}