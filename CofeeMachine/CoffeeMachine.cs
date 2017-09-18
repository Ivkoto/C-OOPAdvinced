using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private IList<CoffeeType> coffeesSold;

    public CoffeeMachine()
    {
        this.coffeesSold = new List<CoffeeType>();
    }

    public IEnumerable<CoffeeType> CoffeesSold => this.coffeesSold;

    private int InsertedCointSum { get; set; }

    public void BuyCoffee(string size, string type)
    {
        CoffeePrice currentPrice;
        CoffeeType currentType;

        Enum.TryParse(size, out currentPrice);
        if (this.InsertedCointSum < (int)currentPrice)
        {
            throw new Exception("not enough coins");
            return;
        }
        Enum.TryParse(type, out currentType);
        this.coffeesSold.Add(currentType);
        this.InsertedCointSum = 0;
    }

    public void InsertCoin(string coint)
    {
        Coin currentCoint;
        Enum.TryParse(coint, out currentCoint);
        this.InsertedCointSum += (int)currentCoint;
    }
}