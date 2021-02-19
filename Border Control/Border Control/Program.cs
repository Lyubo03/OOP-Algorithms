using System;
using System.Collections.Generic;

namespace Border_Control
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<long, Person> persons = new Dictionary<long, Person>();
            Dictionary<long, Robot> robots = new Dictionary<long, Robot>();
            Input(persons, robots);
            long lastDigits = long.Parse(Console.ReadLine());
            DoesRobotIsDangerous(robots, lastDigits);
            DoesPersonIsDangerous(persons, lastDigits);
        }
        static void Input(Dictionary<long, Person> persons, Dictionary<long, Robot> robots)
        {
            string[] input = Console.ReadLine().Split();
            while (input[0].ToLower() != "end")
            {
                if (input.Length > 2)
                {
                    string name = input[0]; int age = int.Parse(input[1]); long id = long.Parse(input[2]);
                    Person person = new Person(name, age, id);
                    if (!persons.ContainsKey(id))
                    {
                        persons[id] = person;
                    }
                }
                else
                {
                    string model = input[0];
                    long id = long.Parse(input[1]);
                    Robot robot = new Robot(model, id);
                    if (!robots.ContainsKey(id))
                    {
                        robots[id] = robot;
                    }
                }
                input = Console.ReadLine().Split();
            }
        }
        static void DoesRobotIsDangerous(Dictionary<long, Robot> robots, long lastDigits)
        {

            int countOfDigits = CountDigits(lastDigits);
            foreach (var robot in robots)
            {
                bool wheather = true;
                long id = robot.Key;
                for (int i = 0; i < countOfDigits; i++)
                {
                    if (lastDigits % 10 != id % 10)
                    {
                        wheather = false;
                        break;
                    }
                    id /= 10;
                    lastDigits /= 10;
                }
                if (wheather == true)
                {
                    Console.WriteLine(robot.Key);
                }
            }
        }
        static void DoesPersonIsDangerous(Dictionary<long, Person> persons, long lastDigits)
        {

            int countOfDigits = CountDigits(lastDigits);
            foreach (var person in persons)
            {
                bool wheather = true;
                long id = person.Key;
                for (int i = 0; i < countOfDigits; i++)
                {
                    if (lastDigits % 10 != id % 10)
                    {
                        wheather = false;
                        break;
                    }
                    id /= 10;
                    lastDigits /= 10;
                }
                if (wheather == true)
                {
                    Console.WriteLine(person.Key);
                }
            }
        }
        static int CountDigits(long digits)
        {
            int counter = 0;
            while (digits != 0)
            {
                digits /= 10;
                counter++;
            }
            return counter;
        }
    }
}
