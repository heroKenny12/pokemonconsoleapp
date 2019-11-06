using PokemonConsoleApp.Foe.PokemonsFoe;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonConsoleApp.Pokemons
{
    public class Butterfree : IPokemon
    {
        private IPokemonFoe _foe;
        private int _life = 110;

        public void SetFoe(IPokemonFoe foe)
        {
            _foe = foe;
        }    

        public void Beated(int attack)
        {
            _life -= attack;
        }

        public int GetLife()
        {
            return _life;
        }

        public void Go()
        {
            Console.WriteLine("Vá butterfree");
        }

        public void ChoiceAttack()
        {
            Console.WriteLine("1- Gust  2- Psybeam  3- Quiver Dance 4- Sleep Powder 5- Trocar de Pokémon");
            var attack = (Console.ReadLine());
            var gust = 40;
            var psybeam = 65;
            

            if ((attack == "1"))
            {
                Console.WriteLine("Você usou tackle");
                Console.ReadKey();
                _foe.Beated(gust);
            }

            if ((attack == "2"))
            {
                Console.WriteLine("Você usou Psybeam");
                _foe.Beated(psybeam);
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

            if ((_foe.GetLife() > 0))
            {
                Console.WriteLine("Red esta com " + (_foe.GetLife()) + " de vida");
                Console.ReadKey();

                _foe.ChoiceAttackFoe();

                //ChoiceAttack(foe); 
            }

            if ((_foe.GetLife() <= 0))
            {
                Console.WriteLine("Você ganhou de Red");
                Console.ReadKey();
            }
        }
    }
}
