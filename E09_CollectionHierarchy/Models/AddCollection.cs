using E09_CollectionHierarchy.Interfaces;

namespace E09_CollectionHierarchy.Models
{
    public class AddCollection<T> : Collection<T>, IAddCollection<T>
    {
        public int Add(T element)
        {
            base.Data.Add(element);
            return this.Data.Count - 1;
        }
    }
}