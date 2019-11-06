using PokemonConsoleApp.Foe.PokemonsFoe;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonConsoleApp.Pokemons
{
    public class Pikachu : IPokemon
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
            Console.WriteLine("Vá pikachu");
        }

        public void ChoiceAttack()
        {
            
            Console.WriteLine("1- Tackle  2- Thunder Wave  3- Thunder");
            var attack = (Console.ReadLine());
            var tackle = 40;
            var thunder = 110;
            

            if ((attack == "1"))
            {
                Console.WriteLine("Você usou tackle");
                Console.ReadKey();
                _foe.Beated(tackle);
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
                _foe.Beated(thunder);
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
