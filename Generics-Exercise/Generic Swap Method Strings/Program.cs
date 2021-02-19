namespace Generic_Swap_Method_Strings
{
    using System;
    using System.Linq;
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                arr[i] = input;
            }

            Swap(arr);

            Console.Write(ToString(arr));
        }
        public static string ToString<T>(T[] arr)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in arr)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

        public static void Swap<T>(T[] arr)
        {
            int[] possitions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            T temp = arr[possitions[0]];
            arr[possitions[0]] = arr[possitions[1]];
            arr[possitions[1]] = temp;
        }
    }
}