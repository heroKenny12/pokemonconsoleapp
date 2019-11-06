using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonConsoleApp.Foe.PokemonsFoe
{
    public interface IPokemonFoe
    {
        void ChoiceAttackFoe();
        void Beated(int gust);
        int GetLife();
    }
}
