
using PokemonTrainer;



Dictionary<string,Trainer> trainers = new();

string command;
while ((command = Console.ReadLine()) != "Tournament")
{
    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string trainerName = tokens[0];
    string pokemonName = tokens[1];
    string element = tokens[2];
    int health = int.Parse(tokens[3]);

    Pokemon pokemon = new Pokemon(pokemonName, element, health);

    if (!trainers.ContainsKey(trainerName))
    {
        trainers.Add(trainerName, new Trainer(trainerName));

    }

    trainers[trainerName].Pokemons.Add(pokemon);
}

string[] elements = new string[3]
{
    "Fire",
    "Water",
    "Electricity"
};

while ((command = Console.ReadLine()) != "End")
{
    string element = command;

    foreach (var (name, trainer) in trainers)
    {
        List<Pokemon> pokemonsToRemove = new();

        if (trainer.Pokemons.Any(x => x.Element == element))
        {
            trainer.Badges++;
        }
        else
        {
            

            trainer.Pokemons.ForEach(pokemon =>
            {
                pokemon.Health -= 10;

                if (pokemon.Health <= 0)
                {
                    pokemonsToRemove.Add(pokemon);
                }
            });
        }

        trainer.Pokemons.RemoveAll(x => pokemonsToRemove.Contains(x));
    }
    
}

foreach (var trainer in trainers.OrderByDescending(x => x.Value.Badges))
{
    Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
}