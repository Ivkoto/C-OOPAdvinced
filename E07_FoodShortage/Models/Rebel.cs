using System;

namespace E07_FoodShortage.Models
{
    public class Rebel : IPersonable, IBuyer
    {
        private const int defaultFood = 0;
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = defaultFood;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get; private set; }

        private string Group { get; set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}