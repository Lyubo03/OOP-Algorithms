using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                result.Add(input[i]);
                for (int j = i; j < input.Count; j++)
                {
                    if (result[result.Count-1]<=0)
                    {
                        result.RemoveAt(result.Count-1);
                        break;
                    }
                    if (result[result.Count-1] > input[j])
                    {
                        result.RemoveAt(result.Count-1);
                        break;
                    }
                }
            }
            foreach (int show in result)
            {
                Console.Write(show.ToString() + ' ');
            }
        }
    }
}
