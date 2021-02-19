namespace CustomStack
{
    using System;
    using System.Collections;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> myStack = new MyStack<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    if (!myStack.Any())
                    {
                        Console.WriteLine("No elements");
                        break;
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        foreach (var item in myStack)
                        {
                            Console.WriteLine(item);
                        }
                    }

                    break;
                }

                else if (command.Contains("Push"))
                {
                    string[] commandSeparator = command.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Skip(1)
                        .ToArray();
                    foreach (var element in commandSeparator)
                    {
                        myStack.Push(element);
                    }
                }

                else if (command == "Pop")
                {
                    if (!myStack.Any())
                    {
                        Console.WriteLine("No elements");
                        break;
                    }
                    myStack.Pop();
                }
            }
        }
    }
}