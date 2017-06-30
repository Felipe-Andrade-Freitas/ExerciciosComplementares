using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComplementar
{
    class Program
    {
        public static void Main(string[] args)
        {
            Investimento investimento = new Investimento();
            Poupanca poupanca = new Poupanca();
            RendaFixa rendaFixa = new RendaFixa();
            
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Valor a ser aplicado: R$");
            poupanca.ValorAplicado = rendaFixa.ValorAplicado = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade de Meses a ser aplicado: ");
            poupanca.QuantMeses = rendaFixa.QuantMeses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Taxa de Juros Poupança: ");
            poupanca.TaxaJuros = Convert.ToDouble(Console.ReadLine());
            Console.Write("Taxa de Juros Renda Fixa: ");
            rendaFixa.TaxaJuros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            
            poupanca.CalculaPoupanca();
            rendaFixa.CalculaRendaFixa();

            investimento.Opcao(poupanca, rendaFixa, rendaFixa.Imposto);

            Console.WriteLine("O valor do seu rendimento é de: R$ {0}", poupanca.ValorTotal);
            Console.WriteLine("O valor do seu rendimento é de: R$ {0}", rendaFixa.ValorTotal);
            Console.WriteLine("O valor do seu rendimento - o IR é de: R$ {0}", rendaFixa.Imposto);
            Console.WriteLine("O melhor {0} com o  valor {1} maior ", investimento.MelhorInvestimento, investimento.ValorMaior);
            Console.WriteLine("------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
