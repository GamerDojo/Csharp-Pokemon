namespace Csharp_Pokemon;

public static class GameProgram
{
    static Pokemon[] pokemons = new Pokemon[] {
        new Pokemon("Pikachu",35,new PokemonAbility[]{ new("Thunder Shock",10)}),
        new Pokemon("Charizard", 50, new PokemonAbility[]{new("Flamethrower",25) }),
        new Pokemon("Bulbasaur", 50, new PokemonAbility[]{new("Vine Whip", 25) }),
        new Pokemon("Squirtle", 35, new PokemonAbility[]{new("Water Gun", 25) }),
        new Pokemon("Jigglypuff", 50, new PokemonAbility[]{new("Pound", 25) }),
        new Pokemon("Gengar", 50, new PokemonAbility[]{new("Shadow Ball", 25) }),
    };
    
    public static void Main()
    {
        var player1 = new Player("Player1");
        var player2 = new Player("Player2"); 
        var round = new Round();
    }
}
