using System.Reflection;
using System.Linq;

public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        var type = typeof(Program);
        var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

        foreach (var methodInfo in methods)
        {
            if (methodInfo.CustomAttributes.Any(a => a.AttributeType == typeof(SoftUniAttribute)))
            {
                var attribs = methodInfo.GetCustomAttributes(false);
                foreach (SoftUniAttribute attrib in attribs)
                {
                    System.Console.WriteLine($"{methodInfo.Name} is written by {attrib.Name}");
                }
            }
        }
    }
}