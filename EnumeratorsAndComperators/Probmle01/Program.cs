namespace Probmle01
{
    using System;
    using System.Linq;
    using System.Net.Http;

    public class Program
    {
        public static void Main(string[] args)
        {
            ListyIterator<string> myList = null;

            while (true)
            {

                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                else
                {
                    try
                    {
                        if (command.Contains("Create"))
                        {
                            string[] nums = command.Split().Skip(1).ToArray();
                            myList = new ListyIterator<string>(nums);
                        }

                        else if (command == "Move")
                        {
                            Console.WriteLine(myList.Move());
                        }

                        else if (command == "HasNext")
                        {
                            Console.WriteLine(myList.MoveNext());
                        }

                        else if (command == "Print")
                        {
                            Console.WriteLine(myList.Print());
                        }
                        else if (command == "PrintAll")
                        {
                            Console.WriteLine(myList.PrintAll());
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

        }
    }
}