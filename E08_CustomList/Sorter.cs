using System;
using System.Linq;
//using System.Linq;

namespace CustomList
{
    public class Sorter
    {
        public static ICustomList<T> Sort<T>(ICustomList<T> customList)
            where T : IComparable<T>
        {
            var temp = customList.MyList.OrderBy(e => e);
            return new CustomList<T>(temp);
        }
    }
}