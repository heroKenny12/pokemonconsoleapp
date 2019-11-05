using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonConsoleApp.Pokemons
{
    public class Pikachu : IPokemon
    {
        public void ChoiceDefense()
        {

        }

        public void Go()
        {
            Console.WriteLine("Vá pikachu");
        }

        public void ChoiceAttack()
        {
            
            Console.WriteLine("1- Tackle  2- Thunder Wave  3- Thunder");
            var attack = (Console.ReadLine());
            var tackle = 40;
            var thunder = 110;
            var foe = 110;

            if ((attack == "1"))
            {
                Console.WriteLine("Você usou tackle");
                Console.ReadKey();
                foe = foe - tackle;
            }

            if ((attack == "2"))
            {
                Console.WriteLine("Você usou thunder wave");
                Console.WriteLine("O seu oponente esta paralisado");
                Console.ReadKey();

            }

            if ((attack == "3"))
            {
                Console.WriteLine("Você usou thunder");
                Console.ReadKey();
                foe = foe - thunder;
                Console.ReadKey();
            }

            if ((foe > 0))
            {
                Console.WriteLine("Red esta com " + (foe) + " de vida");
                Console.ReadKey();
            }

            if ((foe <= 0))
            {
                Console.WriteLine("Você ganhou de Red");
                Console.ReadKey();
            }

        }
    }
}
