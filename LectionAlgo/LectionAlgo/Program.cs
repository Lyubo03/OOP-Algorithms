namespace LectionAlgo
{
    using System;
    public class Program
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
//Stack<int> stack = new Stack<int>();
//string expression = Console.ReadLine();

//            for (int i = 0; i<expression.Length; i++)
//            {
//                if (expression[i] == '(')
//                {
//                    stack.Push(i);
//                }
//                else if (expression[i] == ')')
//                {
//                    string substring = string.Empty;
//int startIndex = stack.Pop();
//                    while (startIndex <= i)
//                    {
//                        substring += expression[startIndex];
//                        startIndex++;
//                    }
//                    Console.WriteLine(substring);
//                }
//            }