using System;

namespace E07_FoodShortage.Models
{
    public class Citizen : IBirthable, IPersonable, IIdentifiable, IBuyer
    {
        private const int defaultFood = 0;
        public Citizen(string name, int age,string id ,string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = defaultFood;
        }

        public string Birthdate { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}