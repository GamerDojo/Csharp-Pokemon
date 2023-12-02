namespace Csharp_Pokemon
{
    public class Player
    {
        public string name;
        public Pokemon[] pokemons;
        public Pokemon activePokemon = null;

        public Player(string name, Pokemon[] pokemons)
        {
            this.name = name;
            this.pokemons = pokemons;
        }

        public void DisplayPokemons()
        {
            Console.WriteLine(name + " pokemons: ");
            for (int i=0;i<pokemons.Length; i++)
            {
                Console.WriteLine($"{i}. {pokemons[i].name}");
            }
        }

        public void SetActivePokemon(int idx)
        {
            activePokemon = pokemons[idx];
            Console.WriteLine(name + " activated " + activePokemon.name);
        }
    }
}
