namespace Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void AddPeople(List<Person> people)
        {
            string[] input = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length - 1; i += 2)
            {

                string name = input[i];
                decimal price = decimal.Parse(input[i + 1]);

                try
                {
                    Person person = new Person(name, price);
                    people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
        static void AddProducts(List<Product> products)
        {
            string[] input = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length - 1; i += 2)
            {

                string name = input[i];
                decimal price = decimal.Parse(input[i + 1]);

                try
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
        static void BuyProduct(List<Person> people, List<Product> products)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] split = input.Split();

                string product = split[1];
                string person = split[0];
                try
                {
                    Person buyer = people.FirstOrDefault(x => x.Name == person);
                    Product buy = products.FirstOrDefault(x => x.Name == product);

                    if (buyer != null && buy != null)
                    {
                        Console.WriteLine(buyer.AddProduct(buy));
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            AddPeople(people);

            List<Product> products = new List<Product>();
            AddProducts(products);

            BuyProduct(people, products);

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}