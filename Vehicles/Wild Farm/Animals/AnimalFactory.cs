namespace Wild_Farm.Animals
{
    using Animals;
    using System;

    public class AnimalFactory
    {
        public AnimalFactory()
        {
        }
        public Animal GetAnimal(params string[] args)
        {
            string type = args[0];
            string name = args[1];
            double weight = double.Parse(args[2]);
            Animal animal = null;
            if (type == "Cat")
            {
                string livingRegion = args[3];
                string breed = args[4];
                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                string livingRegion = args[3];
                string breed = args[4];
                animal = new Tiger(name, weight, livingRegion, breed);
            }
            else if (type == "Dog")
            {
                string livingRegion = args[3];
                animal = new Dog(name, weight, livingRegion);
            }
            else if (type == "Mouse")
            {
                string livingRegion = args[3];
                animal = new Mouse(name, weight, livingRegion);
            }
            else if (type == "Hen")
            {
                double wingSize = double.Parse(args[3]);
                animal = new Hen(name,weight,wingSize);
            }
            else if (type == "Owl")
            {
                double wingSize = double.Parse(args[3]);
                animal = new Owl(name, weight,wingSize);
            }
            else if (animal == null)
            {
                throw new ArgumentException("Incorrect input");
            }
            return animal;
        }
    }
}