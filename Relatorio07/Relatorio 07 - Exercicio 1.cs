using System;

namespace DefesaDeGondor
{
    public class CombatenteAliado
    {
        private string nome;
        private string linhagem;
        private string patente;

        public CombatenteAliado(string nome, string linhagem, string patente)
        {
            this.nome = nome;
            this.linhagem = linhagem;
            this.patente = patente;
        }

        public void ApresentarUnidade()
        {
            Console.WriteLine($"Nome: {nome} | Linhagem: {linhagem} | Patente: {patente}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Forças Aliadas Chegando a Minas Tirith ---\n");

            CombatenteAliado capitaoHumano = new CombatenteAliado("Faramir", "Humano", "Capitão");
            CombatenteAliado guerreiroAnao = new CombatenteAliado("Gimli", "Anão", "Guerreiro");
            CombatenteAliado arqueiroElfo = new CombatenteAliado("Legolas", "Elfo", "Arqueiro");

            capitaoHumano.ApresentarUnidade();
            guerreiroAnao.ApresentarUnidade();
            arqueiroElfo.ApresentarUnidade();
            
            Console.WriteLine("\nPor Gondor!");
        }
    }
}