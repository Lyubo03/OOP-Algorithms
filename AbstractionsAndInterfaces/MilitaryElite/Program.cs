namespace MilitaryElite
{
    using Classes;
    using Enums;
    using Interfaces;
    using Tools;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void AddPirvates(Dictionary<int, ISoldier> army, string[] input)
        {
            int id = int.Parse(input[0]);
            string firstName = input[1];
            string lastName = input[2];
            decimal salary = decimal.Parse(input[3]);

            army[id] = new Private(firstName, lastName, id, salary);
        }
        public static void AddLuitenantGeneral(Dictionary<int, ISoldier> army, string[] input)
        {
            int id = int.Parse(input[0]);
            string firstName = input[1];
            string lastName = input[2];
            decimal salary = decimal.Parse(input[3]);

            LieutenantGeneral luitenant = new LieutenantGeneral(firstName, lastName, id, salary);

            for (int i = 4; i < input.Length; i++)
            {
                int privateId = int.Parse(input[i]);
                luitenant.AddPrivate((IPrivate)army[privateId]);
            }

            army[id] = luitenant;
        }
        public static void AddEngineer(Dictionary<int, ISoldier> army, string[] input)
        {
            int id = int.Parse(input[0]);
            string firstName = input[1];
            string lastName = input[2];
            decimal salary = decimal.Parse(input[3]);
            string corpus = input[4];
            if (corpus != "Airforces" && corpus != "Marines")
            {
                return;
            }
            Corps corp = Corps.Airforces;

            if (corpus == "Marines")
            {
                corp = Corps.Marines;
            }

            Engineer engineer = new Engineer(firstName, lastName, id, salary, corp);

            for (int i = 5; i < input.Length - 1; i += 2)
            {
                string partName = input[i];
                int timeWorked = int.Parse(input[i + 1]);

                Repair repair = new Repair(partName, timeWorked);

                engineer.AddRepair(repair);
            }
            army[id] = engineer;
        }
        public static void AddCommando(Dictionary<int, ISoldier> army, string[] input)
        {
            int id = int.Parse(input[0]);
            string firstName = input[1];
            string lastName = input[2];
            decimal salary = decimal.Parse(input[3]);
            string corpus = input[4];
            if (corpus != "Airforces" && corpus != "Marines")
            {
                return;
            }
            Corps corp = Corps.Marines;
            if (corpus == "Airforces")
            {
                corp = Corps.Airforces;
            }
            
            Commando commando = new Commando(firstName, lastName, id, salary, corp);


            for (int i = 5; i < input.Length; i += 2)
            {
                string missionName = input[i];
                string missionState = input[i + 1];
                if (missionState !="Finished" && missionState !="inProgress")
                {
                    continue;
                }
                State state = State.inProgress;

                if (missionState == "Finished")
                {
                    state = State.Finished;
                }

                Mission mission = new Mission(missionName, state);

                commando.AddMissions(mission);
            }
            army[id] = commando;
        }
        public static void AddSpy(Dictionary<int, ISoldier> army, string[] input)
        {
            int id = int.Parse(input[0]);
            string firstName = input[1];
            string lastName = input[2];
            int codeNumber = int.Parse(input[3]);

            army[id] = new Spy(firstName, lastName, id, codeNumber);
        }
        public static void Main()
        {
            Dictionary<int, ISoldier> army = new Dictionary<int, ISoldier>();

            while (true)
            {
                string enter = Console.ReadLine();
                if (enter == "End")
                {
                    break;
                }

                string command = enter.Split()[0];
                string[] input = enter.Split().Skip(1).ToArray();

                if (command == "Private")
                {
                    AddPirvates(army, input);
                }
                else if (command == "LieutenantGeneral")
                {
                    AddLuitenantGeneral(army, input);
                }
                else if (command == "Engineer")
                {
                    AddEngineer(army, input);
                }
                else if (command == "Commando")
                {
                    AddCommando(army, input);
                }
                else if (command == "Spy")
                {
                    AddSpy(army, input);
                }
            }

            foreach (var soldier in army)
            {
                Console.WriteLine(soldier.Value);
            }
        }
    }
}