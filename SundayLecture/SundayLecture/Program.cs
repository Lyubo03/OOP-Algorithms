using System;
using System.Linq;
namespace SundayLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = Console.ReadLine().Split();
            double[] grades = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double maxGrade = grades[0];
            int index=0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (maxGrade<grades[i])
                {
                    maxGrade = grades[i];
                    index = i;
                    break;
                }
            }
            Console.WriteLine($"{students[index]}\r\n{maxGrade}");
        }
    }
}
