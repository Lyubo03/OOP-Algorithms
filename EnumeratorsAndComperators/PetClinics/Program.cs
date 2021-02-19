namespace PetClinics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Actions(Dictionary<string, Clinic> clinics, Dictionary<string, Pet> pets)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                try
                {
                    if (input.Contains("Create Pet"))
                    {
                        string[] spliter = input.Split().Skip(2).ToArray();

                        string name = spliter[0];
                        int age = int.Parse(spliter[1]);
                        string kind = spliter[2];

                        Pet pet = new Pet(name, age, kind);
                        pets[name] = pet;
                    }

                    else if (input.Contains("Create Clinic"))
                    {
                        string[] spliter = input.Split().Skip(2).ToArray();
                        string name = spliter[0];
                        int rooms = int.Parse(spliter[1]);

                        if (!clinics.ContainsKey(name))
                        {
                            clinics[name] = new Clinic(name, rooms);
                        }
                    }

                    else if (input.Contains("Add"))
                    {
                        string[] spliter = input.Split().Skip(1).ToArray();
                        string petsName = spliter[0];
                        string clinicName = spliter[1];

                        Console.WriteLine(clinics[clinicName].Add(pets[petsName]));
                    }

                    else if (input.Contains("Release"))
                    {
                        string[] clinicsName = input.Split().Skip(1).ToArray();

                        Console.WriteLine(clinics[clinicsName[0]].Realise());
                    }
                    else if (input.Contains("HasEmptyRooms"))
                    {
                        string[] clinicsName = input.Split(' ',StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
                        Console.WriteLine(clinics[clinicsName[0]].HasEmptyRooms());
                    }

                    else if (input.Contains("Print"))
                    {
                        string[] spliter = input.Split().Skip(1).ToArray();
                        string clinic = spliter[0];

                        if (spliter.Length == 1)
                        {
                            Console.WriteLine(clinics[clinic].Print());
                        }
                        else
                        {
                            Console.WriteLine(clinics[clinic].PrintRoom(int.Parse(spliter[1])));
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static void Main()
        {
            Dictionary<string, Clinic> clinics = new Dictionary<string, Clinic>();
            Dictionary<string, Pet> pets = new Dictionary<string, Pet>();

            Actions(clinics, pets);
           
        }
    }
}