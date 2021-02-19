namespace Pizza_Calories
{
    using System;
    public class Dough
    {
        private string flower;
        private string technique;
        private int grams;
        private const double white = 1.5;
        private const double wholegrain = 1.0;
        private const double crispy = 0.9;
        private const double chewy = 1.1;
        private const double homemade = 1.0;
        private const double baseCalories = 2;

        public Dough(string flower, string technique, int grams)
        {
            this.Flower = flower;
            this.Technique = technique;
            this.Grams = grams;
        }
        public int Grams
        {
            get => this.grams;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.grams = value;
            }
        }
        public string Flower
        {
            get => this.flower;
            private set
            {
                string flow = value.ToLower();
                if (flow != "white" && flow != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flower = value;
            }
        }
        public string Technique
        {
            get => this.technique;
            private set
            {
                string tech = value.ToLower();
                if (tech != "homemade" && tech != "chewy" && tech.ToLower() != "crispy")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.technique = value;
            }
        }
        public double DoughCalories => Calculate();
        private double Calculate()
        {
            double calories = baseCalories;
            calories *= grams;

            string tech = technique.ToLower();
            string flow = flower.ToLower(); 

            if (tech == "chewy")
            {
                calories *= chewy;
            }
            else if (tech == "crispy")
            {
                calories *= crispy;
            }
            else if (tech == "homemade")
            {
                calories *= homemade;
            }

            if (flow == "wholegrain")
            {
                calories *= wholegrain;
            }
            else if (flow == "white")
            {
                calories *= white; 
            }

            return calories;
        }
    }
}