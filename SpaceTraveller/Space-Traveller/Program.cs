using System;
using System.Linq;

namespace Space_Traveller
{
    class Program
    {
        static void InitializeGalaxy(char[,] galaxy, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    galaxy[i, col] = input[col];
                }
            }
        }
        static void BlackHole(char[,] galaxy, ref int colIndex, ref int rowIndex, int n)
        {
            galaxy[rowIndex, colIndex] = '-';
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (galaxy[row, col] == 'O')
                    {
                        colIndex = col;
                        rowIndex = row;
                        galaxy[rowIndex, colIndex] = '-';
                        break;
                    }
                }
            }
        }
        static void SearchForPossition(char[,] galaxy, ref int startCol, ref int startRow, int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (galaxy[row, col] == 'S')
                    {
                        startCol = col;
                        startRow = row;
                        galaxy[startRow, startCol] = '-';
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] galaxy = new char[n, n];
            InitializeGalaxy(galaxy, n);
            int startRowIndex = 0;
            int startColIndex = 0;
            SearchForPossition(galaxy, ref startColIndex, ref startRowIndex, n);
            int collectedStars = 0;
            string element = string.Empty;
            bool isCollected = false;
            while (true)
            {
                string commands = Console.ReadLine();

                if (commands == "down")
                {
                    startRowIndex++;
                    if (startRowIndex >= n)
                    {
                        break;
                    }
                    element = galaxy[startRowIndex, startColIndex].ToString();
                    if (element == "O")
                    {
                        BlackHole(galaxy, ref startColIndex, ref startRowIndex, n);
                    }
                    else if (int.TryParse(element, out int number))
                    {
                        collectedStars += number;
                        galaxy[startRowIndex, startColIndex] = '-';
                    }
                }

                else if (commands == "up")
                {
                    startRowIndex--;
                    if (startRowIndex < 0)
                    {
                        break;
                    }
                    if (startRowIndex < 0)
                    {
                        break;
                    }
                    if (element == "O")
                    {
                        BlackHole(galaxy, ref startColIndex, ref startRowIndex, n);
                    }
                    element = galaxy[startRowIndex, startColIndex].ToString();
                    if (int.TryParse(element, out int number))
                    {
                        collectedStars += number;
                        galaxy[startRowIndex, startColIndex] = '-';
                    }
                }

                else if (commands == "left")
                {
                    startColIndex--;
                    if (startRowIndex < 0)
                    {
                        break;
                    }
                    element = galaxy[startRowIndex, startColIndex].ToString();
                    if (element == "O")
                    {
                        BlackHole(galaxy, ref startColIndex, ref startRowIndex, n);
                        continue;
                    }
                    if (int.TryParse(element, out int number))
                    {
                        collectedStars += number;
                        galaxy[startRowIndex, startColIndex] = '-';
                    }
                }

                else if (commands == "right")
                {
                    startColIndex++;
                    if (startColIndex >= n)
                    {
                        break;
                    }
                    element = galaxy[startRowIndex, startColIndex].ToString();
                    if (element == "O")
                    {
                        BlackHole(galaxy, ref startColIndex, ref startRowIndex, n);
                    }
                    else if (int.TryParse(element, out int number))
                    {
                        collectedStars += number;
                        galaxy[startRowIndex, startColIndex] = '-';
                    }
                }

                if (collectedStars >= 50)
                {
                    isCollected = true;
                    galaxy[startRowIndex, startColIndex] = 'S';
                    Console.WriteLine($"Good news!\r\nSthephen succeded in collecting enough star power\r\nStar power collected: {collectedStars}");
                    break;
                }
            }

            if (isCollected == false)
            {
                Console.Write("Bad news!\r\nThe spaceship went to the void.\r\n");
            }

            PrintGalaxy(galaxy, n);
        }
        static void PrintGalaxy(char[,] galaxy, int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(galaxy[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}