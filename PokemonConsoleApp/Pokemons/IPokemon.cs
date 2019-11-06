using PokemonConsoleApp.Foe.PokemonsFoe;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonConsoleApp.Pokemons
{
    public interface IPokemon
    {
        void Go();

        void ChoiceAttack();

        void SetFoe(IPokemonFoe foe);

        void Beated(int attack);

        int GetLife();
    }
}
