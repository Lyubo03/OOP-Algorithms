namespace Zoo
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = k; i < arr.Length; count++, i++)
            {
                int temp = arr[count];
                arr[count] = arr[i];
                arr[i] = temp;
            }
            for (int i = count; i < k; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length-1];
                arr[arr.Length-1] = temp;
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
//456 123 789
//1 2 3 4 5 6 7 8 9
//3
//4 5 6  7 8 9  1 2 3
//1 2 3 4 5
//5 2 3 4 1
//4
//5 1 2 3 4