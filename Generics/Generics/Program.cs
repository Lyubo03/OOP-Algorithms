﻿namespace Generics
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            var scale = new EqualityScale<int>(6, 5);
            Console.WriteLine(scale.AreEqual);
        }
    }
}