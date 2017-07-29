public class Program
{
    public static void Main()
    {
        var scale = new Scale<int>(11, 3);        
        System.Console.WriteLine(scale.GetHavier());
    }
}