namespace JediGalaxy
{
    public class Evil
    {
        private int x;
        private int y;
        public Evil(int[] parameters)
        {
            this.x = parameters[0];
            this.y = parameters[1];
        }
        public void Move(Galaxy galaxy)
        {
            while (x >= 0 && y >= 0)
            {
                if (x >= 0 && x < galaxy.Field.GetLength(0) && y >= 0 && y < galaxy.Field.GetLength(1))
                {
                   galaxy.Field[x, y] = 0;
                }
                x--;
                y--;
            }
        }
    }
}