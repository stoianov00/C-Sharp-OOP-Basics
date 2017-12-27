using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();
        List<Trainer> trainers = new List<Trainer>();

        while (command != "Tournament")
        {
            string[] input = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string trainerName = input[0];
            string pokemonName = input[1];
            string element = input[2];
            int health = int.Parse(input[3]);

            if (trainers.All(t => t.name != trainerName))
            {
                trainers.Add(new Trainer(trainerName));
            }
            
            var trainer = trainers.First(t => t.name == trainerName);
            trainer.pokemons.Add(new Pokemon(pokemonName, element, health));
            
            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.pokemons.Any(p => p.element == command))
                {
                    trainer.badges++;
                }
                else
                {
                    foreach (var pokemon in trainer.pokemons)
                    {
                        pokemon.health -= 10;
                    }

                    trainer.pokemons = trainer.pokemons.Where(p => p.health > 0).ToList();
                }
            }
            command = Console.ReadLine();
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.badges))
        {
            Console.WriteLine($"{trainer.name} {trainer.badges} {trainer.pokemons.Count}");
        }

    }
}

