using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace E02_Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> myList;
        private int currIndex;

        public ListyIterator(params T[] parameters)
        {
            this.currIndex = 0;
            this.myList = new List<T>(parameters);
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                currIndex++;
                return true;
            }
            return false;
        }

        public bool HasNext() => this.currIndex < this.myList.Count - 1;

        public void Print()
        {
            if (this.myList.Count <= 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.myList[this.currIndex]);
            }
        }

        public void PrintAll()
        {
            var sb = new StringBuilder();
            if (this.myList.Count <= 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            else
            {
                foreach (var item in myList)
                {
                    sb.Append($"{item} ");
                }

                Console.WriteLine(sb);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            //return new MyIterator(this.myList); //manual way

            for (int i = 0; i < this.myList.Count; i++)
            {
                yield return this.myList[i]; //the shortiest way
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class MyIterator : IEnumerator<T>
        {
            private int currIndex;
            private readonly IList<T> collection;

            public MyIterator(IEnumerable<T> collection)
            {
                this.Reset();
                this.collection = new List<T>(collection);
            }

            public T Current => this.collection[currIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext() => ++this.currIndex < this.collection.Count;

            public void Reset() => this.currIndex = -1;
        }
    }
}