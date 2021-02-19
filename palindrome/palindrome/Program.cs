namespace palindrome
{
    using System;

    public class Program
    {
        public static void Main()
        {
            while (true)
            {

                string text = Console.ReadLine();

                if (text == "Obi4am te")
                {
                    Console.WriteLine("I az ");
                }
                else if (text == "Prascho")
                {
                    Console.WriteLine("Boby");
                }
                else
                {
                    Console.WriteLine("Slyncho");
                }
            }
        }
    }
}
//string input = Console.ReadLine();
//HashSet<int> store = new HashSet<int>();

//for (int i = 0; i < input.Length; i++)
//{
//    if (input[i] == '0')
//    {
//        int counter = 0;
//        while (input[i] == '0')
//        {
//            i++;
//            counter++;
//            if (i == input.Length)
//            {
//                break;
//            }
//        }
//        if (counter > 1)
//        {
//            bool wheather = true;

//            store.Add(counter);
//        }
//    }
//}

//Console.WriteLine(store.Count);
//zad 1
//string input = Console.ReadLine();
//int count = 0;
//            for (int i = 0; i<input.Length; i++)
//            {
//                if (input[i] == '0')
//                {
//                    int counter = 0;
//                    while (input[i] == '0')
//                    {
//                        i++;
//                        counter++;
//                        if (i == input.Length)
//                        {
//                            break;
//                        }
//                    }
//                    if (counter > 1)
//                    {
//                        count++;
//                    }
//                }
//            }
//            Console.WriteLine(count);
//zad2
//int number = int.Parse(Console.ReadLine());
//string result = string.Empty;

//            while (number != 0)
//            {
//                result = number % 2 + result;
//                number /= 2;
//            }

//            Console.WriteLine(result);