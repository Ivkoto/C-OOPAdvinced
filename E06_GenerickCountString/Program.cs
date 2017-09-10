using System;
using System.Linq;
using System.Collections.Generic;

namespace E06_GenerickCountString
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            IList<Box<string>> list = new List<Box<string>>();
            for (int i = 0; i < n; i++)
            {
                var box = new Box<string>(Console.ReadLine());
                list.Add(box);
            }
            var element = Console.ReadLine();
            Console.WriteLine(CompareCount(list, element));
        }

        public static int CompareCount<T>(IList<Box<T>> list, T element)
            where T : IComparable<T>
        => list.Count(b => b.Data.CompareTo(element) > 0);
    }
}