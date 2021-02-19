using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            char[] open = new char[3] { '(', '[', '{' };

            for (int index = 0; index < s.Length; index++)
            {
                if (open.Contains(s[index]))
                {
                    stack.Push(s[index]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine(false); 
                    }
                    char lastChar = stack.Pop();
                    if ((lastChar == '(' && s[index] != ')') ||
                    (lastChar == '[' && s[index] != ']') ||
                    (lastChar == '{' && s[index] != '}'))
                    {
                        Console.WriteLine( false );
                    }
                }
            }

        }
    }
}