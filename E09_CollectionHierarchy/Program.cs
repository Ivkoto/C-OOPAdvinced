namespace E09_CollectionHierarchy
{
    using E09_CollectionHierarchy.Models;
    using E09_CollectionHierarchy.Interfaces;
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            IAddCollection<string> addColection = new AddCollection<string>();
            IAddRemoveCollection<string> addRemoveColection = new AddRemoveCollection<string>();
            IMyList<string> myList = new MyList<string>();            

            var addCollIndexes = new StringBuilder();
            var addRemCollIndexes = new StringBuilder();
            var myListIndexes = new StringBuilder();
            var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var elem in tokens)
            {
                addCollIndexes.Append($"{addColection.Add(elem)} ");
                addRemCollIndexes.Append($"{addRemoveColection.Add(elem)} ");
                myListIndexes.Append($"{myList.Add(elem)} ");
            }

            var addRemcCollRemovedItems = new StringBuilder();
            var myListRemovedItems = new StringBuilder();
            var removeCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < removeCount; i++)
            {
                addRemcCollRemovedItems.Append($"{addRemoveColection.Remove()} ");
                myListRemovedItems.Append($"{myList.Remove()} ");
            }

            Console.WriteLine(addCollIndexes.ToString().Trim());
            Console.WriteLine(addRemCollIndexes.ToString().Trim());
            Console.WriteLine(myListIndexes.ToString().Trim());

            Console.WriteLine(addRemcCollRemovedItems.ToString().Trim());
            Console.WriteLine(myListRemovedItems.ToString().Trim());
        }
    }
}