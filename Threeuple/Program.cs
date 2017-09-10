using System;

namespace Threeuple
{
    public class Program
    {
        public static void Main()
        {
            var firstArgs = Console.ReadLine().Split(' ');
            var secondArgs = Console.ReadLine().Split(' ');
            var thirdArgs = Console.ReadLine().Split(' ');
            firstArgs = new string[3] { firstArgs[0] + ' ' + firstArgs[1], firstArgs[2], firstArgs[3] };

            var firstTuple = new Threeuple<string, string, string>
                (firstArgs[0], firstArgs[1], firstArgs[2]);

            var secondTuple = new Threeuple<string, int, bool>
                (secondArgs[0], int.Parse(secondArgs[1]), secondArgs[2].Equals("drunk") ? true : false);

            var thirdTuple = new Threeuple<string, double, string>
                (thirdArgs[0], double.Parse(thirdArgs[1]), thirdArgs[2]);

            

            Console.WriteLine(firstTuple.ToString());
            Console.WriteLine(secondTuple.ToString());
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}