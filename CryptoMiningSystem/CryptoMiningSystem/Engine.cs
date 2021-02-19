namespace CryptoMiningSystem
{
    using System;
    using System.Linq;

    public class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            PCController contoller = new PCController();

            while (true)
            {
                string[] data = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];

                if (command == "Shutdown")
                {
                    Console.WriteLine(contoller.Shutdown());
                    return;
                }

                else if (command == "RegisterUser")
                {
                    string name = data[1];
                    double money = double.Parse(data[2]);

                    Console.WriteLine(contoller.RegisterUser(name, money)); 
                }

                else if (command == "Mine")
                {
                    Console.WriteLine(contoller.Mine());
                }

                else if (command == "UserInfo")
                {
                    Console.WriteLine(contoller);
                }

                else if (command == "CreateComputer")
                {
                    Console.WriteLine(contoller.CreateComputer(data.Skip(1).ToArray()));
                }
            }
        }
    }
}