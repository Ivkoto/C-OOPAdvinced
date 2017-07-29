public static class ArrayCreator
{
    public static T[] Create<T>(int length, T ithem)
    {
        return new T[length];
    }
}