namespace Csharp_Pokemon
{
    public class Player
    {
        public string name;
        public Pokemon[] pokemons;

        public Player(string name, Pokemon[] pokemons)
        {
            this.name = name;
            this.pokemons = pokemons;
        }
    }
}
