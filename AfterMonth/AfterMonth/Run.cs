using System;
using System.Linq;

namespace AfterMonth
{
    public class Run
    {
        public Run()
        {
        }
        public void Execute()
        {
            string[] infoVehicle = Console.ReadLine().Split().ToArray();
            Car car = new Car(double.Parse(infoVehicle[1]), double.Parse(infoVehicle[2]));

            infoVehicle = Console.ReadLine().Split().ToArray();
            Truck truck = new Truck(double.Parse(infoVehicle[1]), double.Parse(infoVehicle[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string action = command[0];
                string typeOfVehicle = command[1];
                double digit = double.Parse(command[2]);

                try
                {
                    if (action == "Drive")
                    {
                        if (typeOfVehicle == "Car")
                        {
                            car.Drive(digit);
                        }
                        else if (typeOfVehicle == "Truck")
                        {
                            truck.Drive(digit);
                        }
                    }

                    else if (action == "Refuel")
                    {
                        if (typeOfVehicle == "Car")
                        {
                            car.Refuel(digit);
                        }
                        else if (typeOfVehicle == "Truck")
                        {
                            truck.Refuel(digit);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine(car.ToString() + Environment.NewLine + truck.ToString());
        }
    }
}