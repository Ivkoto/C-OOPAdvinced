using System;
using System.Collections.Generic;
using System.Linq;

namespace E04_GenerickSwap
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            IList<Box<int>> list = new List<Box<int>>();
            for (int i = 0; i < n; i++)
            {
                var box = new Box<int>(int.Parse(Console.ReadLine().Trim()));
                list.Add(box);
            }
            var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Swap(list, indexes[0], indexes[1]);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void Swap<T>(IList<T> list, int firstIndex, int secondIndex)
            where T : class
        {
            T firstElement = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = firstElement;
        }
    }    
}