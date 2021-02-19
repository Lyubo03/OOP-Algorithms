using System;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            double doughCalories = 0;
            double toppingCalories = 0;
            Pizza pizza = new Pizza();
            while (input[0].ToLower() != "end")
            {
                switch (input[0].ToLower())
                {
                    case "dough":
                        string doughType = input[1];
                        string modificator = input[2];
                        double grams = double.Parse(input[3]);
                        Dough dough = new Dough(doughType, modificator, grams);
                        doughCalories = dough.Calories;
                        pizza.AddCalories(doughCalories);
                        break;
                    case "topping":
                        modificator = input[1]; grams = double.Parse(input[2]);
                        Topping topping = new Topping(modificator, grams);
                        toppingCalories = topping.Calories;
                        pizza.AddCalories(toppingCalories);
                        break;
                    case "pizza":
                        pizza.Name = input[1]; break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split();
            }
            Console.WriteLine(pizza.Print());
        }
    }
}
