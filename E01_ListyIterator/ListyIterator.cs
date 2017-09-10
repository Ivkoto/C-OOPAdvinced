using System;
using System.Collections.Generic;

namespace E01_ListyIterator
{
    public class ListyIterator<T>
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
    }
}