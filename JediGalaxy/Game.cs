namespace JediGalaxy
{
    public class Game
    {
        private int ivoPoints;
        private Ivo ivo;
        private Galaxy galaxy;
        private Evil evil;
        public Game(int[] dimensionsGalaxy)
        {
            galaxy = new Galaxy(dimensionsGalaxy);
        }
        public void Play(int[] dimensionsEvil, int[] dimensionsIvo)
        {
            evil = new Evil(dimensionsEvil);
            ivo = new Ivo(dimensionsIvo);
            evil.Move(galaxy);
            ivoPoints += ivo.CollectPoints(galaxy);
        }
        public int ShowPoints { get { return this.ivoPoints; } }
    }
}