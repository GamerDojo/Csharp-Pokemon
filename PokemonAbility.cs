using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Pokemon
{
    public class PokemonAbility
    {
        public string name;
        public int attack;
        public int heal;

        public PokemonAbility(string name, int attack, int heal = 0)
        {
            this.name = name;
            this.attack = attack;
            this.heal = heal;
        }
    }
}
