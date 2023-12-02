namespace Csharp_Pokemon;

public static class GameProgram
{
    static Pokemon[] pokemons = new Pokemon[] {
        new Pokemon("Pikachu",35,new PokemonAbility[]{ new("Thunder Shock",10)}),
        new Pokemon("Charizard", 34, new PokemonAbility[]{new("Flamethrower",25) }),
        new Pokemon("Bulbasaur", 45, new PokemonAbility[]{new("Vine Whip", 22) }),
        new Pokemon("Squirtle", 35, new PokemonAbility[]{new("Water Gun", 32) }),
        new Pokemon("Jigglypuff", 60, new PokemonAbility[]{new("Pound", 13) }),
        new Pokemon("Gengar", 50, new PokemonAbility[]{new("Shadow Ball", 23) }),
    };

    public static Player[] CreatePlayers()
    {
        List<Pokemon> player1Pokemons = new();
        List<Pokemon> player2Pokemons = new();


        for (int i = 0; i < pokemons.Length; i++)
        {
            if (i < 3)
            {
                player1Pokemons.Add(pokemons[i]);
            }
            else
            {
                player2Pokemons.Add(pokemons[i]);
            }
        }

        var player1 = new Player("Player1", player1Pokemons.ToArray());
        var player2 = new Player("Player2", player2Pokemons.ToArray());
        
        return new Player[] {player1, player2};
    }

    public static void Main()
    {
        var players = CreatePlayers();
        var round = new Round();
    }
}
