namespace _04._Pokemon_Trainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainersList = new List<Trainer>();

            string receivedLine = Console.ReadLine();

            while (receivedLine != "Tournament")
            {
                string[] splitInput = receivedLine.Split(" ");

                string trainerName = splitInput[0];
                string pokemonName = splitInput[1];
                string pokemonElement = splitInput[2];
                int pokemonHealth = int.Parse(splitInput[3]);

                Trainer currentTrainer = null;

                foreach (var trainer in trainersList)
                {
                    if (trainer.Name == trainerName)
                    {
                        currentTrainer = trainer;
                    }
                }

                if (currentTrainer == null)
                {
                    currentTrainer = new Trainer(trainerName);
                    trainersList.Add(currentTrainer);
                }

                Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                currentTrainer.Pokemons.Add(newPokemon);

                receivedLine = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                foreach (var trainer in trainersList)
                {
                    bool hasElement = false;

                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element == command)
                        {
                            hasElement = true;
                        }
                    }

                    if (hasElement)
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }

                command = Console.ReadLine();
            }

            trainersList = trainersList
                .OrderByDescending(t => t.Badges)
                .ToList();

            foreach (var trainer in trainersList)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        class Trainer
        {
            public string Name { get; set; }
            public int Badges { get; set; }
            public List<Pokemon> Pokemons { get; set; }

            public Trainer(string name)
            {
                Name = name;
                Badges = 0;
                Pokemons = new List<Pokemon>();
            }
        }



        class Pokemon
        {
            public string Name { get; set; }
            public string Element { get; set; }
            public int Health { get; set; }

            public Pokemon(string name, string element, int health)
            {
                Name = name;
                Element = element;
                Health = health;
            }
        }

    }
}