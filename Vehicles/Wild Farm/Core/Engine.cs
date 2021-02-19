namespace Wild_Farm.Core
{
    using Animals;
    using Food;
    using System;
    using System.Collections.Generic;

    public class Engine : IEngine
    {
        private List<Animal> animals;
        public Engine()
        {
            animals = new List<Animal>();
        }
        public void Run()
        {

            while (true)
            {
                string[] Args = Console.ReadLine().Split();

                if (Args[0] == "End")
                {
                    break;
                }
                Animal animal = CreateAnimal(Args);
                Food food = CreateFood();

                Console.WriteLine(animal.AskForFood());

                try
                {
                    animal.Eat(food);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                animals.Add(animal);
            }
            PrintAnimals();
        }
        private void PrintAnimals()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
        private static Food CreateFood()
        {
            string[] foodArgs = Console.ReadLine().Split();
            FoodFactory factory = new FoodFactory();

            return factory.CreateFood(foodArgs);
        }
        private static Animal CreateAnimal(string[] Args)
        {
            AnimalFactory factory = new AnimalFactory();

            return factory.GetAnimal(Args);
        }
    }
}