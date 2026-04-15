using System;
using System.Collections.Generic;

namespace ArquivosMiskatonic
{

    public abstract class AbominacaoCosmica
    {
        public string Nome { get; set; }

        public AbominacaoCosmica(string nome)
        {
            Nome = nome;
        }

        public abstract void Manifestar();
    }

    public class Shoggoth : AbominacaoCosmica
    {
        public Shoggoth(string nome) : base(nome) { }

        public override void Manifestar()
        {
            Console.WriteLine($"[{Nome}] A massa de protoplasma se arrasta borbulhando, moldando órgãos e olhos conforme avança.");
        }
    }

    public class CacadorAlado : AbominacaoCosmica
    {
        public CacadorAlado(string nome) : base(nome) { }

        public override void Manifestar()
        {
            Console.WriteLine($"[{Nome}] A criatura bate suas asas membranosas, mergulhando do vácuo estelar em um voo silencioso.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Lendo os Manuscritos Proibidos ---\n");

            List<AbominacaoCosmica> horroresCatalogados = new List<AbominacaoCosmica>();

            Shoggoth criaturaAmorfa = new Shoggoth("Pesadelo das Montanhas da Loucura");
            CacadorAlado criaturaAerea = new CacadorAlado("Morte Alada");

            horroresCatalogados.Add(criaturaAmorfa);
            horroresCatalogados.Add(criaturaAerea);

            foreach (AbominacaoCosmica horror in horroresCatalogados)
            {
                horror.Manifestar();
            }

            Console.WriteLine("\n--- Fim do Relato (Que a sua sanidade permaneça intacta) ---");
        }
    }
}