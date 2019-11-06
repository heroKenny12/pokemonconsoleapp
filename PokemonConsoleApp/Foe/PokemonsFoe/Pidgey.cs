using PokemonConsoleApp.Pokemons;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonConsoleApp.Foe.PokemonsFoe
{
    public class Pidgey : IPokemonFoe
    {
        private IPokemon _me;
        private int _life = 110;

        public Pidgey(IPokemon me)
        {
            _me = me;
        }

        public void Beated(int attack)
        {
            _life -= attack;
        }

        public int GetLife()
        {
            return _life;
        }

        public void ChoiceAttackFoe()
        {
            //var tackle = 40;
            //var Gust = 40;

            //Console.WriteLine("Red escolheu um pidgey");
            //Random rnd = new Random();
            //rnd.Next(tackle, Gust);

            Console.WriteLine("1- Tackle  2- Thunder Wave  3- Thunder");
            //var attack = (Console.ReadLine());
            var tackle = 40;
            var thunder = 110;

            Random rnd = new Random();
            var attack = rnd.Next(1, 3).ToString();

            if ((attack == "1"))
            {
                Console.WriteLine("Red usou tackle");
                Console.ReadKey();
                _me.Beated(tackle);
            }

            if ((attack == "2"))
            {
                Console.WriteLine("Red usou thunder wave");
                Console.WriteLine("O seu oponente esta paralisado");
                Console.ReadKey();

            }

            if ((attack == "3"))
            {
                Console.WriteLine("Red usou thunder");
                Console.ReadKey();
                _me.Beated(thunder);
                Console.ReadKey();
            }

            if ((_me.GetLife() > 0))
            {
                Console.WriteLine("Voce esta com " + (_me.GetLife()) + " de vida");
                Console.ReadKey();

                _me.ChoiceAttack();

                //ChoiceAttackFoe(player);
            }

            if ((_me
                
                .GetLife() <= 0))
            {
                Console.WriteLine("Red ganhou de Voce");
                Console.ReadKey();
            }
        }
    }
}
