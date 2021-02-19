using PersonsInfo;
using System;

namespace Try
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Gosho", "Peshev",11,22.33m);
            Console.WriteLine(person);
        }
    }
}
