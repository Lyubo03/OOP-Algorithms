using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sth = new List<int>(20);
            foreach (int item in sth)
            {
                Console.Write(item);
            }
        }
    }
}
