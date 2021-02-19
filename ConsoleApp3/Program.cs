using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            char[] alphabet = new char[28];
            for (char i = 'a'; i <= 'z'; i++)
            {

                alphabet[counter] = i;
                counter++;
            }
            foreach (var item in alphabet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
