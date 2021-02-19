namespace Test
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            char a = 'a';
            string sth = a.ToString();
            string sth1 = (a + a).ToString();
            Console.WriteLine($"{sth} {(char) (a+a)}");
        }
    }
}
//string setOfLetters = Console.ReadLine();
            //string word = Console.ReadLine();
            //int count = 0;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    bool wheather = false;
            //    for (int w = 0; w < setOfLetters.Length; w++)
            //    { 
            //        if (word[0] == setOfLetters[w])
            //        {
            //            count++;
            //            wheather = true;
            //            break;
            //        }
            //    }
            //    if (!wheather)
            //    {
            //        Console.WriteLine(false);
            //        return;
            //    }
            //}

            //if (count == word.Length)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}//int n = int.Parse(Console.ReadLine());
//int faktoriel = 1;
//for (int i = 1; i <= n; i++)
//{
//    faktoriel *= i;
//}
//Console.WriteLine(faktoriel);
//int m = int.Parse(Console.ReadLine());
//int n = int.Parse(Console.ReadLine());

//if (m % 7 != 0)
//{
//    m += 7 - m % 7;
//}

//for (; m < n; m += 7)
//{
//    Console.WriteLine(m);
//}

//int n = int.Parse(Console.ReadLine());
//bool wheather = true;
//for (int i = 2; i*i <= n; i++)
//{
//    if (n % i == 0)
//    {
//        Console.WriteLine("ne e prosto");
//        wheather = false;
//        break;
//    }
//}
//if (wheather)
//{
//    Console.WriteLine("prosto");
//}
