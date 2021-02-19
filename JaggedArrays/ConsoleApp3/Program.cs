using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static int[][] solve(int[] nums)
        {
            SortedDictionary<int, int> numsCount = new SortedDictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numsCount.ContainsKey(nums[i]))
                {
                    numsCount[nums[i]] = 0;
                }
                numsCount[nums[i]]++;
            }
            int[][] jaggedArr = new int[numsCount.Keys.Count][];
            int counter = 0;
            foreach (var kvp in numsCount)
            {
                jaggedArr[counter] = new int[kvp.Value];
                for (int w = 0; w < kvp.Value; w++)
                {
                    jaggedArr[counter][w] = kvp.Key;
                }
                counter++;
            }
            return jaggedArr;
        }
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            solve(nums);
        }
    }
}
//1 1 1 2 3 2 2 4 3 4 5 6 5 8 7 7