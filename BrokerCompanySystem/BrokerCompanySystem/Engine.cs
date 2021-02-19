using System;
using System.Collections.Generic;
using System.Linq;
using BrokerCompanySystem;
namespace BrokerCompanySystem
{

    public class Engine
    {
        private CompanyController controller;
        public Engine()
        {
            controller = new CompanyController();
        }

        public void Run()
        {
            while (true)
            {
                List<string> args = Console.ReadLine().Split('*').ToList();
                string command = args[0];
                args = args.Skip(1).ToList();

                try
                {

                    if (command == "CreateCompany")
                    {
                        Console.WriteLine(controller.CreateCompany(args));
                    }
                    else if (command == "RegisterBuilding")
                    {
                        Console.WriteLine(controller.RegisterBuilding(args));
                    }
                    else if (command == "RegisterBroker")
                    {
                        Console.WriteLine(controller.RegisterBroker(args));
                    }
                    else if (command == "RentBuilding")
                    {
                        Console.WriteLine(controller.RentBuilding(args));
                    }
                    else if (command == "CompanyInfo")
                    {
                        Console.WriteLine(controller.CompanyInfo(args));
                    }
                    else if (command == "Shutdown")
                    {
                        Console.WriteLine(controller.Shutdown());
                        Environment.Exit(1);
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