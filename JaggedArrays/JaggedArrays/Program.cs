using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JaggedArrays
{
    class Program
    {
        //3, 4, -1, 1
        //1, 2, 3
        static int solve(int[] nums)
        {
            List<int> list = new List<int>();
            list = nums.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                bool wheather = false;
                for (int w = 0; w < list.Count-1; w++)
                {
                    if (list[w] < 1)
                    {
                        list.RemoveAt(w);
                    }
                    else if (list[w] > list[w + 1])
                    {
                        int temp = list[w];
                        list[w] = list[w + 1];
                        list[w + 1] = temp;
                        wheather = true;
                    }
                }
                if (!wheather)
                {
                    break;
                }
            }
            int min = list[0];
            while (true)
            {
                if (!list.Contains(min) && min>0)
                {
                    return min;
                }
                min++;
            }
        }
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(new char[] { ',', ' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(solve(num));
        }
    }
}