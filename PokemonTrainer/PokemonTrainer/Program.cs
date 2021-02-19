using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while (input[0] != "Tournament")
            {
                string trainerName = input[0]; string pokemonName = input[1]; string pokemonElement = input[2]; int pockemonHealth = int.Parse(input[3]);
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pockemonHealth);
                trainers[trainerName].Pokemons.Add(pokemon);
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            string enterElements = Console.ReadLine();
            while (enterElements != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any())
                    {
                        trainer.Value.GainBages(enterElements);
                    }
                }
                enterElements = Console.ReadLine();
            }
            foreach (var trainer in trainers.OrderByDescending(x => x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
