namespace JediGalaxy
{
    public class Galaxy
    {
        private int x;
        private int y;
        private int[,] field;
        public Galaxy(int[] parameters)
        {
            this.x = parameters[0];
            this.y = parameters[1];
            this.field = new int[x, y];
            InitialiseGalaxy(field);
        }
        public void InitialiseGalaxy(int[,] field)
        {
            int value = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    field[i, j] = value++;
                }
            }
        }
        public int[,] Field { get { return this.field; } }
    }
}