namespace Pizza_Calories
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = null;
            try
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "END")
                    {
                        break;
                    }

                    string[] spliter = input.Split();
                    string command = spliter[0];


                    if (command == "Pizza")
                    {
                        string name = spliter[1];
                        pizza = new Pizza(name);
                    }

                    string ingridient = spliter[1];

                    if (command == "Topping")
                    {

                        int grams = int.Parse(spliter[2]);
                        Topping topping = new Topping(ingridient, grams);
                        pizza.AddTopping(topping);

                    }

                    else if (command == "Dough")
                    {
                        string technique = spliter[2];
                        int grams = int.Parse(spliter[3]);
                        Dough dough = new Dough(ingridient, technique, grams);
                        pizza.Dough = dough;
                    }


                }

                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}