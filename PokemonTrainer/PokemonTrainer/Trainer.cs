using System.Collections.Generic;
namespace PokemonTrainer
{
    class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;
        public Trainer(string name)
        {
            this.name = name;
            this.numberOfBadges = 0;
            this.pokemons = new List<Pokemon>();
        }
        public string Name
        {
            get { return name; }
        }
        public int NumberOfBadges
        {
            get { return numberOfBadges; }
        }
        public List<Pokemon> Pokemons
        {
            set { pokemons = value; }
            get { return pokemons; }
        }
        public void GainBages(string element)
        {
            bool wheather = false;
            foreach (var pokemon in pokemons)
            {
                if (pokemon.Element == element)
                {
                    wheather = true;
                    break;
                }
            }
            if (wheather == true)
            {
                numberOfBadges += 1;
            }
            else
            {
                foreach (var pokemon in pokemons)
                {
                    if (pokemon.Health <= 10)
                    {
                        pokemons.Remove(pokemon);
                        if (pokemons.Count==0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        pokemon.Health -= 10;
                    } 
                }
            }
        }
    }
}
