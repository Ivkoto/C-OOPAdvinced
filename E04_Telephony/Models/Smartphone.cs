using System;
using System.Linq;

namespace E04_Telephony.Models
{
    public class Smartphone : ISmartphone
    {
        public Smartphone(string model)
        {
            this.Model = model;
        }
        public string Model { get; private set; }

        public string Browse(string url)
        {
            if (url.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {url}!";            
        }

        public string Call(string number)
        {
            if (number.All(char.IsDigit))
            {
                return $"Calling... {number}";
            }
            return "Invalid number!";
        }
    }
}