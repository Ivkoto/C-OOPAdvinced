namespace Threeuple
{
    public class Threeuple<T, U, N>
    {
        public Threeuple(T item1, U item2, N item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public T Item1 { get; set; }

        public U Item2 { get; set; }

        public N Item3 { get; set; }


        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
        }
    }
}