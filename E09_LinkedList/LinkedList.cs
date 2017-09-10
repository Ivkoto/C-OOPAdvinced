namespace E09_LinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
    {
        private Node firstElement;

        public class Node
        {            

            public Node(T value)
            {
                this.Data = value;
            }

            public T Data { get; set; }

            public Node Next { get; set; }

            public Node Prev { get; set; }

            public override string ToString() => this.Data.ToString();
        }

        public Node Head { get; private set; }
        public Node Tails { get; private set; }
        public int Count { get; private set; }

        public void Add(T element)
        {
            var old = this.Tails;
            this.Tails = new Node(element);

            if (this.Count == 0)
            {
                this.Head = this.Tails;
                this.firstElement = this.Head;
            }
            else
            {
                this.Head.Next = this.Tails;
                this.Tails.Prev = this.Head;
                this.Head = this.Tails;
            }
            this.Count++;
        }

        public bool Remove(T element)
        {
            var currentNode = firstElement;

            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }
            while (currentNode != null)
            {
                if (currentNode.Data.Equals(element))
                {
                    if (currentNode.Prev != null)
                    {
                        currentNode.Prev.Next = currentNode.Next;
                    }
                    else
                    {
                        currentNode = currentNode.Next;
                        currentNode.Prev = null;
                        this.firstElement = this.firstElement.Next;
                        this.firstElement.Prev = null;
                    }
                    if (currentNode.Next != null)
                    {
                        currentNode.Next.Prev = currentNode.Prev;
                    }
                    //else
                    //{
                    //    currentNode.Prev.Next = null;
                    //}

                    this.Count--;
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = this.firstElement;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}