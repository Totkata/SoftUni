using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var trainers = new Dictionary<string, Trainer>();

            while (input != "Tournament")
            {
                AddTrainers(trainers, input);

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                EarnBadges(trainers, command);

                command = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.NumberOfBadges} {trainer.Value.Pokemons.Count}");
            }
        }

        private static void HealthCheck(Trainer trainer)
        {
            for (int i = 0; i < trainer.Pokemons.Count; i++)
            {
                if (trainer.Pokemons[i].Health <= 0)
                {
                    trainer.Pokemons.Remove(trainer.Pokemons[i]);
                }
            }
        }

        private static void EarnBadges(Dictionary<string, Trainer> trainers, string command)
        {
            foreach (var trainer in trainers.Values)
            {
                if (trainer
                    .Pokemons
                    .Any(x => x.Element == command))
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                }
                HealthCheck(trainer);
            }
        }

        private static void AddTrainers(Dictionary<string, Trainer> trainers, string input)
        {
            string[] splitedInput = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string name = splitedInput[0];
            string pokemonName = splitedInput[1];
            string element = splitedInput[2];
            int health = int.Parse(splitedInput[3]);

            var pokemon = new Pokemon(pokemonName, element, health);

            if (!trainers.ContainsKey(name))
            {
                trainers[name] = new Trainer(name);
            }
            trainers[name].Pokemons.Add(pokemon);

        }

    }
}
