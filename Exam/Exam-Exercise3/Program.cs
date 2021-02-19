using System;
using System.Collections.Generic;

namespace Exam_Exercise3
{
    class Program
    {
        static void FindSpecialWords(string word, List<string> specialWords, List<string> ordinaryWords)
        {
            bool containsI = false;
            if (word[0] + 0 > 64 && word[0] + 0 < 91 && word.Length > 7)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] + 0 == 105 || word[i] + 0 == 73)
                    {
                        containsI = true;
                        break;
                    }
                }
            }
            if (containsI)
            {
                specialWords.Add(word);
            }
            else
            {
                ordinaryWords.Add(word);
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> specialWords = new List<string>();
            List<string> ordinaryWords = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                FindSpecialWords(word, specialWords, ordinaryWords);
            }
            Console.WriteLine($"Special words: {string.Join(", ", specialWords)}");
            Console.WriteLine($"Other words: {string.Join(", ", ordinaryWords)}");
        }
    }
}