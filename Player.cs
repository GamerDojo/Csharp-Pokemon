﻿namespace Csharp_Pokemon
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

        public void SetActivePokemon(int idx)
        {
            activePokemon = pokemons[idx];
        }
    }
}
