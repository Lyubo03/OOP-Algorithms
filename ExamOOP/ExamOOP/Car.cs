using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOOP
{
    public class Car
    {
        private string name;
        private int number;
        private double price;
        public Car(int number, double price)
        {
            this.number = number;
            if (price < 1000)
            {
                throw new ArgumentException("Invalid car price!");
            }
            else
            {
                this.price = price;
            }
        }
        public string Name { get { return this.name; } }
        public int Number { get { return this.number; } }
        public double Price { get { return this.price; } }
    }
}