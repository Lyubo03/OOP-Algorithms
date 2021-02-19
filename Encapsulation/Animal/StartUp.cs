namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Beast!")
                {
                    break;
                }

                string[] data = Console.ReadLine().Split();

                string name = data[0];
                int age = int.Parse(data[1]);
                Animal animal = null;
                try
                {


                    if (input == "Tomcat")
                    {
                        animal = new Tomcat(name, age);
                    }

                    else if (input == "Kittens")
                    {
                        animal = new Kitten(name, age);
                    }
                    else
                    {
                        string gender = data[2];

                        if (input == "Cat")
                        {
                            animal = new Cat(name, age, gender);
                        }

                        else if (input == "Dog")
                        {
                            animal = new Dog(name, age, gender);
                        }

                        else if (input == "Frog")
                        {
                            animal = new Frog(name, age, gender);
                        }
                    }

                    animals.Add(animal);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name}{Environment.NewLine}{animal}");
            }
        }
    }
}