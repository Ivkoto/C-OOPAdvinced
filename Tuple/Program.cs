using System;

namespace Tuple
{
    public class Program
    {
        public static void Main()
        {
            var firstArgs = Console.ReadLine().Split(' ');
            var secondArgs = Console.ReadLine().Split(' ');
            var thirdArgs = Console.ReadLine().Split(' ');
            firstArgs = new string[2] { firstArgs[0] + ' ' + firstArgs[1], firstArgs[2] };

            var firstTuple = new MyTuple<string, string>(firstArgs[0], firstArgs[1]);
            var secondTuple = new MyTuple<string, int>(secondArgs[0], int.Parse(secondArgs[1]));
            var thirdTuple = new MyTuple<int, double>(int.Parse(thirdArgs[0]), double.Parse(thirdArgs[1]));

            Console.WriteLine(firstTuple.ToString());
            Console.WriteLine(secondTuple.ToString());
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}