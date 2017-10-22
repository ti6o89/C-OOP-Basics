using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_11.Pokemon_Trainer
{
    class StartUp
    {
        static void Main()
        {
            var trainers = new List<Trainer>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                var tokens = input.Split().ToArray();

                var trainerName = tokens[0];
                var pokemonName = tokens[1];
                var element = tokens[2];
                var helth = int.Parse(tokens[3]);

                var pokemon = new Pokemon(pokemonName, element, helth);
                var trainer = new Trainer(trainerName);
                

                if (trainers.Any(t => t.Name == trainer.Name))
                {
                    trainers.Where(t => t.Name == trainer.Name).First().Pokemons.Add(pokemon);
                }
                else
                {
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                
            }

            var elements = new List<string>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                
                elements.Add(command);
            }

            foreach (var element in elements)
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.NumberOfBadges ++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(h => h.Helth -= 10);
                        trainer.Pokemons.RemoveAll(p => p.Helth <= 0);
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count()}");
            }
        }
    }
}
