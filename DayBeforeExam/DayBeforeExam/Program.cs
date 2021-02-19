
using System;
using System.Linq;

namespace DayBeforeExam
{
    class Program
    {
        static void RightMoves(int[] planes, ref int startPoss,ref int damage, int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (startPoss == planes.Length - 1)
                {
                    damage++;
                    startPoss = 0;
                }
                else
                {
                    startPoss++;
                }
                planes[startPoss] -= damage;
            }
        }
        static void LeftMoves(int[] planes, ref int startPoss,ref int damage, int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (startPoss == 0)
                {
                    damage++;
                    startPoss = planes.Length-1;
                }
                else
                {
                    startPoss--;
                }
                planes[startPoss] -= damage;
            }
        }
        static void Main(string[] args)
        {
            int[] planes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startPoss = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int damage = 1;
            while (input[0].ToLower() != "supernova")
            {
                int steps = int.Parse(input[1]);
                string direction = input[0];
                if (direction.ToLower() == "right")
                {
                    RightMoves(planes, ref startPoss,ref damage, steps);
                }
                else
                {
                    LeftMoves(planes, ref startPoss, ref damage, steps);
                }
                input = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", planes));
        }
    }
}
