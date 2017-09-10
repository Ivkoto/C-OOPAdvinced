using System.Collections.Generic;

namespace E09_CollectionHierarchy.Models
{
    public abstract class Collection<T>
    {
        public Collection()
        {
            this.Data = new List<T>();
        }

        public IList<T> Data { get; set; }
    }
}