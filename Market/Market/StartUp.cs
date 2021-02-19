using System;
using System.Collections.Generic;

namespace Market
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            List<Person> persons = new List<Person>();
            Stack<string> bag = new Stack<string>();
            List<Product> products = new List<Product>();
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                string name = input[i]; decimal money = decimal.Parse(input[i + 1]);
                Person person = new Person(name, money);
                persons.Add(person);
            }
            input = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                string productName = input[i]; decimal productPrice = decimal.Parse(input[i + 1]);
                Product product = new Product();
                product.SetPrice(productPrice); product.SetName(productName);
                products.Add(product);
            }
            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (input[0].ToLower() != "end")
            {
                string nameOfPerson = input[0];
                string productName = input[1];
                decimal productPrice = 0;
                Product product = new Product();
                foreach (var goods in products)
                {
                    if (productName == goods.NameOfProduct)
                    {
                        product = goods;
                        productPrice = goods.ProductPrice;
                        break;
                    }
                }
                foreach (var person in persons)
                {
                    if (person.Name == nameOfPerson)
                    {
                        person.DoesTheMoneyEnough(productPrice, product);
                        break;
                    }
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Name} - {person.PrintProducts().TrimEnd(',', ' ')}");
            }
        }
    }
}
