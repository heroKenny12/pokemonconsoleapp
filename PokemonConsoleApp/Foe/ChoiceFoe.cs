using PokemonConsoleApp.Foe.PokemonsFoe;
using PokemonConsoleApp.Pokemons;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonConsoleApp.Foe
{
    public class ChoiceFoe
    {
        public static IPokemonFoe ChoicePokemonFoe(IPokemon me)
        {
            List<IPokemonFoe> foes = new List<IPokemonFoe>();
            foes.Add(new Pidgey(me));
            foes.Add(new Pidgey(me));
            foes.Add(new Pidgey(me));

            Random rnd = new Random();
            var foeId = rnd.Next(0, foes.Count - 1);

            return foes[foeId];
        }
    }
}
