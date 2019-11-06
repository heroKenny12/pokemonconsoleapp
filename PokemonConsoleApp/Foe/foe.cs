using PokemonConsoleApp.Foe.PokemonsFoe;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonConsoleApp.Foe
{
    class foe
    {
        public void ChoicePokemonFoe()
        {
            Random rnd = new Random();
            rnd.Next(new Pidgey());
        }
    }
}
