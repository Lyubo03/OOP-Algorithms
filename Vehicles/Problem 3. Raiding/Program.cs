namespace Raiding
{
    using Raiding.Core;
    class Program
    {
        static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}