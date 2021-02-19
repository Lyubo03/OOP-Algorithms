using ConsoleApp14;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp13
{
    class Program
    {
        static void Input(Queue<Room> rooms)
        {
            string[] input = Console.ReadLine().Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                string name = input[i]; int num = int.Parse(input[i + 1]);
                Room room = new Room(name, num);
                rooms.Enqueue(room);
            }
        }
        static bool Execution(Queue<Room> rooms, Hero pesho)
        {
            bool wheather = false;
            int count = 0;
            while (rooms.Any())
            {
                Room room = rooms.Dequeue();
                count++;
                string name = room.Name; int num = room.Range;
                if (name.ToLower() == "potion")
                {
                    pesho.Heal(num);
                }
                else if (name.ToLower() == "chest")
                {
                    pesho.FindedCoins(num);
                }
                else
                {
                    wheather = pesho.Battle(num, name);
                    if (!wheather)
                    {
                        Console.WriteLine($"Best room: {count}");
                        break;
                    }
                }
            }
            return wheather;
        }
        static void Main(string[] args)
        {
            Hero pesho = new Hero();
            Queue<Room> rooms = new Queue<Room>();
            Input(rooms);
            if (Execution(rooms, pesho))
            {
                Console.WriteLine($"You've made it! Coins: {pesho.Coins} Health: {pesho.Health}");
            }
        }
    }
}