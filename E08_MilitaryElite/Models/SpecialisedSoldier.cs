using System.Linq;
using E08_MilitaryElite.Interfaces;

namespace E08_MilitaryElite.Models
{
    enum corpTypes { Airforces, Marines }
    public class SpecialisedSoldier : Private ,ISpecialisedSoldier
    {
        private string corp;

        public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corp) 
            : base(id, firstName, lastName, salary)
        {
            this.Corp = corp;
        }

        public string Corp
        {
            get { return this.corp; }

            private set
            {
                if (value.Equals(corpTypes.Airforces.ToString()) || value.Equals(corpTypes.Marines.ToString()))
                {
                    this.corp = value;
                }
            }
        }

    }
}