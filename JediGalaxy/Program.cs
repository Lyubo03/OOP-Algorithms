namespace JediGalaxy
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Game game = new Game(dimestions);
            string command = Console.ReadLine();
            while (true)
            {
                int[] ivoS = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evil = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                game.Play(evil, ivoS);

                command = Console.ReadLine();
                if (command == "Let the Force be with you")
                {
                    break;
                }
            }

            Console.WriteLine(game.ShowPoints);

        }
    }
}