namespace CollectionHierarchy
{
    using System;
    public class Program
    {
        static void Main()
        {
            string[] elements = Console.ReadLine().Split();
            AddCollection<string> addCollection = new AddCollection<string>();
            AddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
            MyList<string> myList = new MyList<string>();

            Console.WriteLine(addCollection.Add(elements));
            Console.WriteLine(addRemoveCollection.Add(elements));
            Console.WriteLine(myList.Add(elements));

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(addRemoveCollection.Remove(n));
            Console.WriteLine(myList.Remove(n));
        }
    }
}