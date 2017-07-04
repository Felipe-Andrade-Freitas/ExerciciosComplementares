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

            if (poupanca.ValorTotal > rendaFixa.Imposto)
            {
                investimento.MelhorInvestimento = "A melhor opção é a Poupança";
                investimento.ValorMaior = poupanca.ValorTotal - rendaFixa.Imposto;
            }
            else if (poupanca.ValorTotal < rendaFixa.Imposto)
            {
                investimento.MelhorInvestimento = "A melhor opção é a Renda Fixa";
                investimento.ValorMaior = poupanca.ValorTotal - rendaFixa.Imposto;
            }
            else
            {
                investimento.MelhorInvestimento = "Os dois apresentam os Valores iguais";
            }
            
            var x = 1;
            Console.WriteLine("O rendimento mensal da Poupança é:\n");
            foreach (var listaJuros in poupanca.ListaRendimento)
            {                 
                Console.WriteLine("O juros do mês {0} é de R${1: #0.00}", x, listaJuros);
                x++;
            }

            Console.WriteLine("------------------------------------------------------");
            var y = 1;
            Console.WriteLine("O rendimento mensal da Renda Fixa sem o desconto do IR é:\n");
            foreach (var listaJuros in rendaFixa.ListaRendimento)
            {
                Console.WriteLine("O juros do mês {0} é de R${1: #0.00}", y, listaJuros);
                y++;
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("O valor do seu rendimento da Poupança é de: R${0: #0.00}\n", poupanca.ValorTotal);
            Console.WriteLine("O valor do seu rendimento da Renda Fixa é de: R${0: #0.00}\n", rendaFixa.ValorTotal);
            Console.WriteLine("O valor do seu rendimento menos o IR é de: R${0: #0.00}\n", rendaFixa.Imposto);
            Console.WriteLine("{0} pois o  valor de diferença é de R${1: #0.00}\n", investimento.MelhorInvestimento, investimento.ValorMaior);
            Console.WriteLine("------------------------------------------------------");
            

            Console.ReadLine();
        }
    }
}
