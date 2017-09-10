namespace E01_GenericBox
{
    public class Box<T> : IBox<T>
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