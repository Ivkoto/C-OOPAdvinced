using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E03_Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private const int initialCapacity = 8;
        private T[] data;

        public Stack()
        {
            this.data = new T[initialCapacity];
        }

        private int Count { get; set; } //used like a index

        private int Capacity => this.data.Length; //current capacity of the array

        public void Push(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.Resize();
            }

            this.data[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            var lastElement = this.data[this.Count - 1];
            this.Count--;
            return lastElement;
        }

        private void Resize()
        {
            Array.Resize(ref this.data, 2 * this.Capacity);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}