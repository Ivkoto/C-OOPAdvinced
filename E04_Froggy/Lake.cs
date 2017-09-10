using System.Collections;
using System.Collections.Generic;

namespace E04_Froggy
{
    public class Lake : IEnumerable<int>
    {
        private readonly List<int> stones;

        public Lake(IEnumerable<int> numbers)
        {
            this.stones = new List<int>(numbers);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i += 2)
            {
                yield return this.stones[i];
            }
            var oddIndes = (this.stones.Count - 1) % 2 != 0 ? this.stones.Count - 1 : this.stones.Count - 2;
            for (int i = oddIndes; i > 0; i -= 2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}