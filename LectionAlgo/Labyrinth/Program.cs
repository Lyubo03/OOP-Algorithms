namespace Labyrinth
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static char[,] field;
        private static List<char> paths = new List<char>();
        public static void FindPaths(int row, int col, char symbol)
        {
            if (!IsInBounds(row, col))
            {
                return;
            }
            else if (field[row, col] == 'e')
            {
                PrintSolution(symbol);
                return;
            }
            else if (IsVisited(row, col) && IsPassable(row, col))
            {
                MarkPossition(row, col, symbol);
                FindPaths(row + 1, col, 'D');
                FindPaths(row - 1, col, 'U');
                FindPaths(row, col - 1, 'L');
                FindPaths(row, col + 1, 'R');
                UnmarkPossition(row, col);
            }
        }

        private static bool IsVisited(int row, int col)
        {
            if (field[row, col] == '-')
            {
                return true;
            }
            return false;
        }

        private static bool IsPassable(int row, int col)
        {
            if (field[row, col] != '*')
            {
                return true;
            }
            return false;
        }

        private static bool IsInBounds(int row, int col)
        {

            if (row < 0 || row >= field.GetLength(0) || col < 0 || col >= field.GetLength(1))
            {
                return false;
            }
            return true;
        }

        private static void UnmarkPossition(int row, int col)
        {
            field[row, col] = '-';
            if (paths.Count > 0)
            {
                paths.RemoveAt(paths.Count - 1);
            }

        }

        private static void MarkPossition(int row, int col, char symbol)
        {
            field[row, col] = symbol;
            if (symbol != 'S')
            {
                paths.Add(symbol);
            }

        }

        private static void PrintSolution(char symbol)
        {
            foreach (var direction in paths)
            {
                Console.Write(direction);
            }
            Console.Write(symbol);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            GetField();
            FindPaths(0, 0, 'S');
        }
        public static void GetField()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            field = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < col; j++)
                {
                    field[i, j] = input[j];
                }
            }
        }
    }
}