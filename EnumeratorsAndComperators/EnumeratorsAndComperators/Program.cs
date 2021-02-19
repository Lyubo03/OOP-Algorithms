using System;

namespace EnumeratorsAndComperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 6,5,4,2,1 };
            Numbers numbers = new Numbers(array);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
