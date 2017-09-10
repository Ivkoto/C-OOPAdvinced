using E09_CollectionHierarchy.Interfaces;
using System.Linq;

namespace E09_CollectionHierarchy.Models
{
    public class AddRemoveCollection<T> : Collection<T>, IAddRemoveCollection<T>
    {
        public int Add(T element)
        {
            this.Data.Insert(0, element);
            return 0;
        }

        public T Remove()
        {
            var lastElement = this.Data.LastOrDefault();
            this.Data.RemoveAt(this.Data.Count - 1);
            return lastElement;
        }
    }
}