namespace TowerOfHanoi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static Stack<int> source;
        static Stack<int> auxiliary = new Stack<int>();
        static Stack<int> destination = new Stack<int>();
        static int n;
        static int steps = 0;
        private static void SolveHanoi(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> auxiliary)
        {
            if (bottomDisk == 1)
            {
                steps++;
                destination.Push(source.Pop());
                Console.WriteLine($"Step #{steps}: Moved disk {destination.Peek()}");
                Print();
            }
            else
            {
                SolveHanoi(bottomDisk - 1, source, auxiliary, destination);
                steps++;
                destination.Push(source.Pop());

                Console.WriteLine($"Step #{steps}: Moved disk {destination.Peek()}");
                Print();
                SolveHanoi(bottomDisk - 1, auxiliary, destination, source);
            }
        }
        private static void Print()
        {
            Console.WriteLine($"Source: {string.Join(", ", source.Reverse())}");
            Console.WriteLine($"Spare: {string.Join(", ", auxiliary.Reverse())}");
            Console.WriteLine($"Destination: {string.Join(", ", destination.Reverse())}");
            Console.WriteLine();
        }

        private static void Main()
        {
            Func<int, int, int> Calculate = (a, b) =>
            {
                return a + b;
            };
            //n = int.Parse(Console.ReadLine());
            //source = new Stack<int>(Enumerable.Range(1, n).Reverse());
            //Print();
            //SolveHanoi(n, source, destination, auxiliary);

            Console.WriteLine(Calculate(5,11));
        }
    }
}