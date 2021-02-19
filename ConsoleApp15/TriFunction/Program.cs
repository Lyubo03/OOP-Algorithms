namespace TriFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int> Lenght = name =>
             {
                 char[] toChar = name.ToCharArray();
                 int count = 0;

                 for (int i = 0; i < toChar.Length; i++)
                 {
                     count += toChar[i];
                 }

                 return count;
             };

            Func<string, Func<string, int>, int, bool> isEqual = (name, nameLength, length) => nameLength(name) >= length;

            names = names.Where(n => isEqual(n, Lenght, parameter)).ToList();

            Console.WriteLine(string.Join(" ", names));
        }
    }
}

