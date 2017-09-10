using System;
using System.Collections.Generic;
using System.Linq;

namespace E07_GenericCountDouble
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            IList<Box<double>> list = new List<Box<double>>();
            for (int i = 0; i < n; i++)
            {
                var box = new Box<double>(double.Parse(Console.ReadLine()));
                list.Add(box);
            }
            var element = double.Parse(Console.ReadLine());
            Console.WriteLine(CompareCount(list, element));
        }

        public static int CompareCount<T>(IList<Box<T>> list, T element)
            where T : IComparable<T>
        => list.Count(b => b.Data.CompareTo(element) > 0);
    }
}