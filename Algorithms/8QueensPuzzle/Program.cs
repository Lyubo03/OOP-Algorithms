namespace _8QueensPuzzle
{
    using System;

    public class Program
    {
        private const int Size = 8;
        public static bool[,] board = new bool[Size, Size];

        public static void PutQueens(int row)
        {
            if (row == Size)
            {
                PrintSolution();
                Console.WriteLine();
                return;
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPut(row, col))
                    {
                        MarkAttackedFields(row, col);
                        PutQueens(row + 1);
                        UnmarkAttackedFields(row, col);
                    }
                }
            }
        }

        private static void UnmarkAttackedFields(int currentRow, int currentCol)
        {
            board[currentRow, currentCol] = false;
        }

        private static void MarkAttackedFields(int currentRow, int currentCol)
        {
            int sum = currentRow + currentCol;
            int difference = currentRow - currentCol;

            board[currentRow, currentCol] = true;
        }
        private static bool CanPut(int currentRow, int currentCol)
        {
            for (int row = 0; row < Size; row++)
            {
                if (board[currentRow, row] == true && row != currentCol)
                {
                    return false;
                }

                else if (board[row, currentCol] == true && row != currentRow)
                {
                    return false;
                }
                for (int col = 0; col < Size; col++)
                {
                    if (row + col == currentRow + currentCol && board[row, col] == true && row != currentRow && col != currentCol)
                    {
                        return false;
                    }

                    else if (row - col == currentRow - currentCol && board[row, col] == true && row != currentRow && col != currentCol)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (board[row, col] == true)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            PutQueens(0);
        }
    }
}