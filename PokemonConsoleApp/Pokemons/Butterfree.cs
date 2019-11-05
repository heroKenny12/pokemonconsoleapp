using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonConsoleApp.Pokemons
{
    public class Butterfree : IPokemon
    {
        public void Go()
        {
            Console.WriteLine("Vá butterfree");
        }

        public void ChoiceAttack()
        {
            Console.WriteLine("1- Gust  2- Psybeam  3- Quiver Dance 4- Sleep Powder 5- Trocar de Pokémon");
            var attack = (Console.ReadLine());
            var Gust = 40;
            var Psybeam = 65;
            var foe = 110;

            if ((attack == "1"))
            {
                Console.WriteLine("Você usou tackle");
                Console.ReadKey();
                foe = foe - Gust;
            }

            if ((attack == "2"))
            {
                Console.WriteLine("Você usou thunder wave");
                Console.WriteLine("O seu oponente esta paralisado");
                Console.ReadKey();

            }

            if ((attack == "3"))
            {
                Console.WriteLine("Você usou Quiver Dance");
                Console.ReadKey();
                Console.WriteLine("O Sp.Attack, Sp.Defense e Speed aumentaram em 1 estágio");
                Console.ReadKey();

            }

            if ((attack == "4"))
            {
                Console.WriteLine("Você usou Sleep Powder");
                Console.ReadKey();
                Console.WriteLine("O seu oponente adormeceu");
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
