namespace Shapes
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int spaces = n;
            Console.Write(new string(' ',spaces+1));
            Console.WriteLine('*');
            int between = 1;
            for (int i = 2; spaces >= 0; i++,spaces--,between+=2)
            {
                Console.Write(new string(' ',spaces));
                Console.Write('*');
                Console.Write(new string('*', between));
                Console.WriteLine('*');
            }
        }
    }
}