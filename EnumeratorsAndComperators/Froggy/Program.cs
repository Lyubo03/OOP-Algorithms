namespace Froggy
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(stones);

            string res = $"{string.Join(", ", lake)}, ";

            lake.Enumerator = new ReverseEnumerator(stones);

            res += $"{string.Join(", ", lake)}";

            Console.WriteLine(res);
        }
    }
}
