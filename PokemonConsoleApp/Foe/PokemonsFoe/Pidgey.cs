using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonConsoleApp.Foe.PokemonsFoe
{
    public class Pidgey
    {
        public void ChoiceAttackFoe(int player = 100, int foe = 110)
        {
            var tackle = 40;
            var Gust = 40;

            Console.WriteLine("Red escolheu um pidgey");
            Random rnd = new Random();
            rnd.Next(tackle, Gust);
            
        }
    }
}
