namespace Vehicles
{
    using Core;
    public class Program
    {
        public static void Main()
        {
            Engine engine = new Engine();
            engine.Run();
            System.Console.WriteLine(engine.FinalInput);
        }
    }
}