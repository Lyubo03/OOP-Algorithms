namespace Basic
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //for (int i = 0; i < n * 2; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            Func<int[], int, int> Sum = (array, n) =>
              {
                  int sum = 0;
                  n--;
                  for (int i = 0; i <= n; i++)
                  {
                      sum += array[i] * array[n * 2 - i];
                  }
                  return sum;
              };

            Console.WriteLine(Sum(array, n));

            Func<int[], int, int> MaxTBT = (array, n) =>
               {
                   int[] resArr = new int[n];
                   n--;
                   for (int i = 0; i <= n; i++)
                   {
                       int min = array[i];
                       if (min > array[n * 2 - i])
                       {
                           min = array[n * 2 - i];
                       }
                       resArr[i] = min;
                   }

                   int max = resArr[0];

                   for (int i = 1; i < resArr.Length; i++)
                   {
                       if (resArr[i] > max)
                       {
                           max = resArr[i];
                       }
                   }

                   return max;
               };

            Console.WriteLine(MaxTBT(array, n));

            Func<int[], int, int> MaxOfThree = (array, n) =>
            {
                int right = 0;
                int left = n * 2 - 1;
                int minLeft = array[left];
                int minRight = array[right];

                left--;
                right++;

                while (right < left)
                {
                    if (minRight > array[right])
                    {
                        minRight = array[right];
                    }
                    if (minLeft > array[left])
                    {
                        minLeft = array[left];
                    }
                    left--;
                    right++;
                }

                if (minLeft>minRight)
                {
                    return minLeft;
                }

                return minRight;
            };
            Console.WriteLine(MaxOfThree(array,n));
        }
    }
}