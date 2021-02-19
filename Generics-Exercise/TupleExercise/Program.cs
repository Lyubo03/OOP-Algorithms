namespace TupleExercise
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string city = input[3];
            string name = $"{input[0]} {input[1]}";
            string adress = input[2];
            Tuple<string, string, string> nameAdressCity = new Tuple<string, string,string>(name, adress,city);

            input = Console.ReadLine().Split();
            name = input[0];
            int beers = int.Parse(input[1]);
            bool wheather = false;
            if (input[2] == "drunk")
            {
                wheather = true;
            }
            Tuple<string, int,bool> nameBeers = new Tuple<string, int,bool>(name, beers,wheather);

            input = Console.ReadLine().Split();
            name = input[0];
            double money = double.Parse(input[1]); 
            string bankName= input[2];
            Tuple<string, double, string> integerDouble = new Tuple<string, double, string>(name, money ,bankName);

            Console.WriteLine(nameAdressCity.ToString());
            Console.WriteLine(nameBeers.ToString());
            Console.WriteLine(integerDouble.ToString());
        }
    }
}
