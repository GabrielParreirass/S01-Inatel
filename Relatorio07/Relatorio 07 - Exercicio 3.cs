using System;
using System.Collections.Generic;

namespace JornadaFrieren
{
    public class ReliquiaMagica
    {
        public string NomeItem { get; set; }

        public ReliquiaMagica(string nomeItem)
        {
            NomeItem = nomeItem;
        }
    }
    public class BauDeReliquias
    {
        private List<ReliquiaMagica> reliquias;

        public BauDeReliquias()
        {
            reliquias = new List<ReliquiaMagica>();
        }

        public void GuardarItem(ReliquiaMagica item)
        {
            reliquias.Add(item);
            Console.WriteLine($"[Baú] {item.NomeItem} foi guardado com segurança.");
        }
    }

    public class ItemDeAcampamento
    {
        public string NomeItem { get; set; }

        public ItemDeAcampamento(string nomeItem)
        {
            NomeItem = nomeItem;
        }
    }

    public class Maga
    {
        public string Nome { get; set; }
        
        public BauDeReliquias Bau { get; private set; } 

        public List<ItemDeAcampamento> KitAcampamento { get; set; } 

        public Maga(string nome, List<ItemDeAcampamento> kitAcampamento)
        {
            Nome = nome;
            
            Bau = new BauDeReliquias(); 
            
            KitAcampamento = kitAcampamento;
        }

        public void MostrarItensDeAcampamento()
        {
            Console.WriteLine($"\n--- Kit de Acampamento de {Nome} ---");
            foreach (var item in KitAcampamento)
            {
                Console.WriteLine($"- {item.NomeItem}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando a jornada...\n");

            List<ItemDeAcampamento> itensDaEstrada = new List<ItemDeAcampamento>
            {
                new ItemDeAcampamento("Saco de Dormir"),
                new ItemDeAcampamento("Pote de Cozinha"),
                new ItemDeAcampamento("Lanterna a Óleo")
            };

            Maga frieren = new Maga("Frieren", itensDaEstrada);

            frieren.Bau.GuardarItem(new ReliquiaMagica("Anel de Prata"));
            frieren.Bau.GuardarItem(new ReliquiaMagica("Grimório Antigo de Flamme"));

            frieren.MostrarItensDeAcampamento();
            
            Console.WriteLine("\nA jornada continua...");
        }
    }
}