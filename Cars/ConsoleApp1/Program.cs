using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> cars = new Dictionary<string,HashSet<string>>();
            cars["Mercedes"] = new HashSet<string>();
            cars["Mercedes"].Add("Gosho");
            cars["Mercedes"].Add("Gosho");
            foreach (var item in cars.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
