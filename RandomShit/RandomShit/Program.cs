using System;
using System.Linq;
using System.Collections.Generic;
namespace RandomShit
{
    class Program
    {
        public static bool solve(int[] nums)
        {
            Dictionary<int, int> numsAndCount = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numsAndCount.ContainsKey(nums[i]))
                {
                    numsAndCount[nums[i]] = 0;
                }
                numsAndCount[nums[i]]++;
            }
            bool wheather = true;
            for (int i = 0; i < numsAndCount.Count; i++)
            {
                for (int w = 0; w < numsAndCount.Count; w++)
                {
                    if (numsAndCount[i] == numsAndCount[w])
                    {
                        wheather = false;
                    }
                }
                if (!wheather)
                {
                    break;
                }
            }
            return wheather;
        }
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(solve(nums));
        }
    }
}