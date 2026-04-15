using System;
using System.Collections.Generic;

namespace BatalhaPokemon
{
    public class Pokemon
    {
        public string Especie { get; set; }

        public Pokemon(string especie)
        {
            Especie = especie;
        }

        public virtual void ExecutarMovimento()
        {
            Console.WriteLine($"{Especie} executa um movimento normal de combate!");
        }
    }

    public class TipoFogo : Pokemon
    {
        public TipoFogo(string especie) : base(especie) { }

        public override void ExecutarMovimento()
        {
            Console.WriteLine($"{Especie} lança uma poderosa rajada de chamas!");
        }
    }

    public class TipoAgua : Pokemon
    {
        public TipoAgua(string especie) : base(especie) { }

        public override void ExecutarMovimento()
        {
            Console.WriteLine($"{Especie} dispara uma bolha de água em alta velocidade!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Início do Treinamento Pokémon ---\n");

            List<Pokemon> equipePokemon = new List<Pokemon>();

            TipoFogo scorbunny = new TipoFogo("Scorbunny");
            TipoAgua greninja = new TipoAgua("Greninja");

            equipePokemon.Add(scorbunny);
            equipePokemon.Add(greninja);

            foreach (Pokemon pokemonAtual in equipePokemon)
            {
                pokemonAtual.ExecutarMovimento();
            }

            Console.WriteLine("\n--- Treinamento Concluído ---");
        }
    }
}