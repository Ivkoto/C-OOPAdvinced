using System;

public class Scale<T> : IScalable<T>
    where T : IComparable<T>
{
    private T left;
    private T right;

    public Scale(T left, T right)
    {
        this.Right = right;
        this.Left = left;
    }

    private T Left { get; set; }

    private T Right { get; set; }

    public T GetHavier()
    {
        if (this.Left.CompareTo(this.Right) > 0)
        {
            return this.Left;
        }
        else if (this.Left.CompareTo(this.Right) < 0)
        {
            return this.Right;
        }

        return default(T);
    }
}