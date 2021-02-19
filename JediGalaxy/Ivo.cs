using System.Reflection;

namespace JediGalaxy
{
    public class Ivo
    {
        private int x;
        private int y;
        public Ivo(int[] parameters)
        {
            this.x = parameters[0];
            this.y = parameters[1];
        }
        public int CollectPoints(Galaxy galaxy)
        {
            int points = 0;
            while (x >= 0 && y < galaxy.Field.GetLength(1))
            {
                if (x >= 0 && x < galaxy.Field.GetLength(0) && y >= 0 && y < galaxy.Field.GetLength(1))
                {
                    points += galaxy.Field[x, y];
                }

                y++;
                x--;
            }
            return points;
        }
    }
}