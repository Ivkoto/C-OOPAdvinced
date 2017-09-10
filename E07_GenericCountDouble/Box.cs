using System;

namespace E07_GenericCountDouble
{
    public class Box<T>
        where T: IComparable<T>
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