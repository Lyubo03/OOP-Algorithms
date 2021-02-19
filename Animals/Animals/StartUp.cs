using System;
using System.Collections.Generic;

namespace Animals
{
    public class Program
    {
        static void ListOfAnimals(List<Animal> animals)
        {
            string input = Console.ReadLine();
            while (input.ToLower() != "beast!")
            {
                switch (input.ToLower())
                {

                    case "dog":
                        string[] animalInfo = Console.ReadLine().Split();
                        string name = animalInfo[0];
                        int age = int.Parse(animalInfo[1]);
                        string gender = animalInfo[2];
                        Dog dog = new Dog(name, age, gender);
                        animals.Add(dog);
                        break;
                    case "frog":
                        animalInfo = Console.ReadLine().Split();
                        name = animalInfo[0];
                        age = int.Parse(animalInfo[1]);
                        gender = animalInfo[2];
                        Frog frog = new Frog(name, age, gender);
                        animals.Add(frog);
                        break;
                    case "cat":
                        animalInfo = Console.ReadLine().Split();
                        name = animalInfo[0];
                        age = int.Parse(animalInfo[1]);
                        gender = animalInfo[2];
                        Cat cat = new Cat(name, age, gender);
                        animals.Add(cat);
                        break;
                    case "kitten":
                        animalInfo = Console.ReadLine().Split();
                        name = animalInfo[0];
                        age = int.Parse(animalInfo[1]);
                        Kitten kitten = new Kitten(name, age);
                        animals.Add(kitten);
                        break;
                    case "tomcat":
                        animalInfo = Console.ReadLine().Split();
                        name = animalInfo[0];
                        age = int.Parse(animalInfo[1]);
                        TomCat tomcat = new TomCat(name, age);
                        animals.Add(tomcat);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            ListOfAnimals(animals);
            Print(animals);
        }
        static void Print(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender} {animal}");
                animal.ProduceSound();
            }
        }
    }
}
