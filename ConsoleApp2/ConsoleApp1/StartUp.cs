namespace ConsoleApp1
{
    using System;

    public class Program
    {
        public static bool DoesAutomorphus(long a)
        {

        }
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.CursorTop(i);

            }
        }
    }
}
//string word = Console.ReadLine();
//string[] clues = new string[2];
//string[] helper;
//bool wheather = false;
//List<int> info = new List<int>();
//while (wheather == false)
//{
//    helper = Console.ReadLine().Split(' ').ToArray();
//    clues = helper;
//    int counter = 0;
//    char symbol = Convert.ToChar(clues[0]);
//    int num = Convert.ToInt32(clues[1]);
//    for (int i = 0; i < word.Length; i++)
//    {
//        if (word[i] == symbol)
//        {
//            counter++;

//        }
//        else if (counter >= num && word[i] != symbol)
//        {
//            Console.WriteLine("“Hideout found at index " + (i - counter) + "and it is with size" + counter + " !”");
//            wheather = true;
//            break;
//        }
//        else
//        {
//            counter = 0;
//        }
//    }