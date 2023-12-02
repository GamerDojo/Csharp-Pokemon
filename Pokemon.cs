namespace Csharp_Pokemon
{
    public class Pokemon
    {
        public string name;
        
        public int health;

        public PokemonAbility[] abilities;

        public Pokemon(string name, int health, PokemonAbility[] abilities)
        {
            this.name = name;
            this.health = health;
            this.abilities = abilities;
        }
    }
}
