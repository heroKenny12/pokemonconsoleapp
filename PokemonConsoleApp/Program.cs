﻿using PokemonConsoleApp.Foe;
using PokemonConsoleApp.Foe.PokemonsFoe;
using PokemonConsoleApp.Pokemons;
using System;

namespace PokemonConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {            
            IPokemon myPokemon = ChoicePokemon();
            IPokemonFoe foe = ChoiceFoe.ChoicePokemonFoe(myPokemon);

            myPokemon.SetFoe(foe);

            myPokemon.Go();
            myPokemon.ChoiceAttack();
            

            Console.ReadLine();
        }

        private static IPokemon ChoicePokemon()
        {
            Console.WriteLine("Escolha um pokemon: [P]ikachu ou [B]utterfree");
            var pokemonChoiced = Console.ReadLine();

            switch (pokemonChoiced.ToLower())
            {
                case "p":
                    return new Pikachu();
                case "b":
                    return new Butterfree();
                default:
                    return ChoicePokemon();
            }
        }
    }

    
}

