using System;
using System.Linq;
namespace SpaceTraveller
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
            bool isCollected = true;
            while (true)
            {
                string commands = Console.ReadLine();
                switch (commands.ToLower())
                {
                    case "down":
                        if (startRowIndex == n-1)
                        {
                            isCollected = false;
                            break;
                        }
                        else
                        {
                            startRowIndex++;
                            element = galaxy[startRowIndex, startColIndex].ToString();
                            if (int.TryParse(element, out int number))
                            {
                                collectedStars += number;
                            }
                            else if (element == "O")
                            {
                                BlackHole(galaxy, ref startColIndex, ref startRowIndex, n);
                            }
                        }
                        break;
                    case "up":
                        if (startRowIndex == 0)
                        {
                            isCollected = false;
                            return;
                        }
                        else
                        {
                            startRowIndex--;
                            element = galaxy[startRowIndex, startColIndex].ToString();
                            if (int.TryParse(element, out int number))
                            {
                                collectedStars += number;
                            }
                            else if (element == "O")
                            {
                                BlackHole(galaxy, ref startColIndex, ref startRowIndex , n);
                            }
                        }
                        break;
                    case "left":
                        if (startRowIndex == 0)
                        {
                            isCollected = false;
                            break;
                        }
                        else
                        {
                            startColIndex--;
                            element = galaxy[startRowIndex, startColIndex].ToString();
                            if (int.TryParse(element, out int number))
                            {
                                collectedStars += number;
                            }
                            else if (element == "O")
                            {
                                BlackHole(galaxy, ref startColIndex, ref startRowIndex , n);
                            }
                        }
                        break;
                    case "right":
                        if (startColIndex == n-1)
                        {
                            isCollected = false;
                            break;
                        }
                        else
                        {
                            startColIndex++;
                            element = galaxy[startRowIndex, startColIndex].ToString();
                            if (int.TryParse(element, out int number))
                            {
                                collectedStars += number;
                            }
                            else if (element == "O")
                            {
                                BlackHole(galaxy, ref startColIndex, ref startRowIndex , n);
                            }
                        }
                        break;
                    default: break;
                }
                if (collectedStars>= 50)
                {
                    break;
                }
            }
            if (isCollected)
            {
                Console.WriteLine("Good news!\r\nSthephen succeded in collecting enough star power");
            }
            else
            {
                Console.WriteLine("Bad news!\r\nThe spaceship went to the void.\r\n");
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
                        galaxy[row, col] = '-';
                        break;
                    }
                }
            }
        }
    }
}