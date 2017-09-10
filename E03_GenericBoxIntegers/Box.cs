namespace E03_GenericBoxIntegers
{
    public class Box<T> : IBox<T>
        where T : struct
    {
        public Box(T element)
        {
            this.Data = element;
        }

        private T Data { get; set; }

        public override string ToString()
        {
            return $"{this.Data.GetType().FullName}: {this.Data}";
        }
    }
}