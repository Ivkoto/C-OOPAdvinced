using System;

namespace E05_BorderControl.Models
{
    public class Citizen : IIdentifiable
    {
        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
        public string Id { get; private set; }
        private string Name { get; set; }
        private int Age { get; set; }
    }
}