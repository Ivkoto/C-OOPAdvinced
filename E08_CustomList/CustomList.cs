using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomList
{
    public class CustomList<T> : ICustomList<T>, IEnumerable
        where T : IComparable<T>
    {
        public CustomList() : this(Enumerable.Empty<T>())
        {
        }

        public CustomList(IEnumerable<T> collection)
        {
            this.MyList = new List<T>(collection);
        }

        public IList<T> MyList { get; private set; }

        public void Add(T element) => this.MyList.Add(element);

        public bool Contains(T element) => this.MyList.Contains(element);

        public int CountGreaterThan(T element) => this.MyList.Count(e => e.CompareTo(element) > 0);

        public T Max() => this.MyList.Max();

        public T Min() => this.MyList.Min();

        public T Remove(int index)
        {
            var removedElem = this.MyList[index];
            this.MyList.RemoveAt(index);
            return removedElem;
        }

        public void Swap(int index1, int index2)
        {
            var firstElement = this.MyList[index1];
            this.MyList[index1] = this.MyList[index2];
            this.MyList[index2] = firstElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.MyList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}