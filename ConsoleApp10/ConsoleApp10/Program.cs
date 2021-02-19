using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Input(Queue<Room> rooms)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                Room room = new Room(input[i], int.Parse(input[i + 1]));
                rooms.Enqueue(room);
            }
        }
        static void Main(string[] args)
        {
            Queue<Room> rooms = new Queue<Room>();
            Input(rooms);
            Hero hero = new Hero();
            int roomCount = 0;
            bool alive = true;
            while (rooms.Any())
            {
                Room room = rooms.Dequeue();
                roomCount++;
                string roomName = room.Name; int roomPoints = room.Points;
                if (roomName.ToLower() == "potion")
                {
                    Console.WriteLine(hero.Potion(roomPoints));
                }
                else if (room.Name.ToLower() == "chest")
                {
                    hero.Coins = roomPoints;
                    Console.WriteLine($"You found {roomPoints} coins.");
                }
                else
                {
                    hero.Health = roomPoints;
                    if (hero.Health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {roomName}.\r\nBest room: {roomCount}");
                        rooms.Enqueue(room); alive = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {roomName}.");
                    }
                }
            }
            if (alive)
            {
                Console.WriteLine($"You've made it!, Coins: {hero.Coins}, Health: {hero.Health}");
            }
        }
    }
}
