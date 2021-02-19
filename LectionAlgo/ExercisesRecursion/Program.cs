namespace ExercisesRecursion
{
    using System;

    class Program
    {
        public static int[] loopArr;
        static void Print()
        {
            Console.WriteLine(string.Join(' ', loopArr));
        }
        static void NestedLoops(int endCount, int index)
        {
            if (index >= loopArr.Length)
            {
                Print();
                return;
            }


            for (int i = 1; i <= endCount; i++)
            {
                loopArr[index] = i;
                NestedLoops(endCount, index + 1);
            }

        }
        static void Main()
        {
            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            loopArr = new int[n];
            NestedLoops(n, 0);
        }
    }
}