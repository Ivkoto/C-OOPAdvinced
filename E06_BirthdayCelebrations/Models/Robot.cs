using System;

namespace E06_BirthdayCelebrations.Models
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public string Id { get; private set; }
        private string Model { get; set; }
    }
}