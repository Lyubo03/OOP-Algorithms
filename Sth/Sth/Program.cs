namespace Sth
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', b));

            for (int i = 0; i < a; i++)
            {
                Console.Write('*');
                Console.Write(new string(' ', b-2));
                Console.WriteLine('*');
            }

            Console.WriteLine(new string('*', b));

        }
    }
}