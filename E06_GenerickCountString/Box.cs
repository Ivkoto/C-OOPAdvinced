using System;

namespace E06_GenerickCountString
{
    public class Box<T>
    {
        public Box(T element)
        {
            this.Data = element;
        }

        public T Data { get; private set; }        

        public override string ToString()
        {
            return $"{this.Data.GetType().FullName}: {this.Data}";
        }
    }
}