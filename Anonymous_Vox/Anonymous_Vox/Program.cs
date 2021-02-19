using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Vox
{
    class Program
    {
        static void Merge(List<string> elements, string[] input)
        {
            int startIndex = int.Parse(input[1]); int endIndex = int.Parse(input[2]);
            if (endIndex > elements.Count)
            {
                endIndex = elements.Count;
            }
            for (int i = 0, counter = 0; i < elements.Count - 1; i++)
            {
                if (i >= startIndex && endIndex > i)
                {
                    elements[counter] += elements[i + 1];
                    elements.RemoveAt(i + 1);
                    i--; endIndex--;
                }
                else
                {
                    elements[counter] = elements[i];
                    counter++;
                }
            }
        }
        static void Main(string[] args)
        {
            List<string> elements = new List<string>();
            elements = Console.ReadLine().Split().ToList();
            string[] input = Console.ReadLine().Split();
            while (input[0] != "3:1")
            {
                switch (input[0].ToLower())
                {
                    case "merge":
                        Merge(elements, input);
                        break;
                    case "divide":
                        int index = int.Parse(input[1]); int partitions = int.Parse(input[2]);
                        char[] wordToSeparate = elements[index].ToCharArray();
                        for (int i = index; i < elements.Count; i++)
                        {
                            
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
