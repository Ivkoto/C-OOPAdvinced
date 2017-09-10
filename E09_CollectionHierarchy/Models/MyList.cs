using E09_CollectionHierarchy.Interfaces;
using System.Linq;

namespace E09_CollectionHierarchy.Models
{
    internal class MyList<T> : Collection<T>, IMyList<T>
    {
        public int Used { get => this.Data.Count; }

        public int Add(T element)
        {
            this.Data.Insert(0, element);
            return 0;
        }

        public T Remove()
        {
            var firstElement = base.Data.FirstOrDefault();
            base.Data.RemoveAt(0);
            return firstElement;
        }
    }
}