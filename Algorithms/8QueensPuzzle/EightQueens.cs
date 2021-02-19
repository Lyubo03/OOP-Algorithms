namespace _8QueensPuzzle
{
    public class EightQueens
    {
        public bool[,] chessBoard;
        public EightQueens(int size)
        {
            Size = size;
            chessBoard = new bool[Size, Size];
        }
        public bool[,] ChessBoard => SchessBoard;

        public int Size { get; private set; }

    }
}