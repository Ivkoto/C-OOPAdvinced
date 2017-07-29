using E08_MilitaryElite.Interfaces;

namespace E08_MilitaryElite.Models
{
    internal enum stateStat
    { inProgress, finished }

    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        private string state;

        public string CodeName { get; private set; }

        public string State
        {
            get { return this.state; }
            private set
            {
                if (value.Equals(stateStat.finished.ToString()) || value.Equals(stateStat.inProgress.ToString()))
                {
                    this.state = value;
                }
            }
        }

        public void CompleteMission()
        {
            State = stateStat.finished.ToString();
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.state}";
        }
    }
}