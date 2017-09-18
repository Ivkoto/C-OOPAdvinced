using System;

public class Program
{
    public static void Main()
    {
        CoffeeMachine machine = new CoffeeMachine();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] inputArgs = input.Split();
            if (inputArgs.Length == 1)
            {
                machine.InsertCoin(inputArgs[0]);
            }
            else
            {
                try
                {
                    machine.BuyCoffee(inputArgs[0], inputArgs[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }

        foreach (var coffeeType in machine.CoffeesSold)
        {
            Console.WriteLine(coffeeType);
        }

    }
}