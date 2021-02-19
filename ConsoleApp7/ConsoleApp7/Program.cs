using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader read = new StreamReader(@"..\..\..\..\TextFile1.txt");
            using StreamWriter write = new StreamWriter(@"..\..\..\..\TextFile2.txt", true);
            int counter = 1;
            while (true)
            {
                string res = read.ReadLine();
                if (res == null)
                {
                    break;
                }
                write.WriteLine($"{counter}. { res}");
                counter++;
            }
        }
    }
}
