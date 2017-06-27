using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComplementar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis
            //Variáveis
            double valorAplicado, rendPoupanca, quantMeses;
            double rendaFixa;

            //Variáveis relacionado a Poupança
            double jurosCompPoupanca = 0, juros;

            //Variáveis relacionado a Renda Fixa
            double totalRendaFixa;
            double valorFinalRendaFixa;
            double valorFinalRendaFixaImposto;
            double impostoDeRenda;
            double valorRendaFixaImpostoRenda;
            string op2 = "Renda Fixa";
            #endregion

            //Iniciando a Calculadora Financeira
            Console.WriteLine("Bem Vindo á Calculadora Financeira");
            Console.WriteLine("Responda as perguntas abaixo: ");
            Console.WriteLine("");

            //Entrada de Dados
            Console.Write("Qual o valor a ser aplicado? R$");
            valorAplicado = double.Parse(Console.ReadLine());
            Console.Write("Qual a porcentagem dos rendimentos mensais para poupaca? ");
            rendPoupanca = Math.Round(Convert.ToDouble(Console.ReadLine()),2);
            Console.Write("Qual a porcentagem dos rendimentos mensais para renda fixa? ");
            rendaFixa = double.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de meses que o dinheiro ficará aplicado? ");
            quantMeses = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Saida de Dados

            //Poupança
            Console.WriteLine("Poupança: ");
            Console.WriteLine("");
            #region Poupança
            for (double x = 0; x <= quantMeses; x++)
            {
                jurosCompPoupanca = valorAplicado * rendPoupanca * quantMeses / 100;
            }

            juros = jurosCompPoupanca;
            jurosCompPoupanca += valorAplicado;

            Console.WriteLine("O valor a receber é: {0}", jurosCompPoupanca);
            #endregion
            //valorFinalPoupanca = totalPoupanca + valorInvestido;
            Console.WriteLine("O valor que renderá para poupanca será de R$" + juros + ".");
            Console.WriteLine("O valor do seu investimento mais o seu valor aplicado será de R$" + jurosCompPoupanca + ".");
            Console.WriteLine("");
            Console.WriteLine("");
            /*
            //Renda Fixa
            Console.WriteLine("Renda Fixa: ");
            Console.WriteLine("");
            totalRendaFixa = rendaFixa * valorInvestido * meses / 100;
            valorFinalRendaFixa = totalRendaFixa + valorInvestido;
            Console.WriteLine("O valor que renderá para renda fixa será de R$" + valorFinalRendaFixa);
            Console.WriteLine("");
            Console.WriteLine("");

            //Imposto de Renda
            if(meses <= 12)
            {
                impostoDeRenda = totalRendaFixa * 25 / 100;
                valorRendaFixaImpostoRenda = totalRendaFixa - impostoDeRenda;
                valorFinalRendaFixaImposto = totalRendaFixa + valorInvestido - impostoDeRenda;
                Console.WriteLine("Imposto de Renda: ");
                Console.WriteLine("");
                Console.WriteLine("Você pagara R$" + impostoDeRenda + " de imposto de renda");
                Console.WriteLine("O valor que renderá para renda fixa menos o imposto de renda será de R$" + valorRendaFixaImpostoRenda + ".");
                Console.WriteLine("O valor do seu investimento mais o seu valor aplicado menos o imposto será de R$" + valorFinalRendaFixaImposto + ".");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Opção de investimento: ");
                Console.WriteLine("");
                if (valorFinalPoupanca > valorFinalRendaFixaImposto)
                {
                    Console.WriteLine("A melhor opção de invesimentos é " + op1 + ".");
                }
                else
                {
                    Console.WriteLine("A melhor opção de investimento é " + op2 + ".");
                }
                Console.WriteLine("");
            }
            else if(meses > 13 && meses > 24)
            {
                impostoDeRenda = totalRendaFixa * 15 / 100;
                valorRendaFixaImpostoRenda = totalRendaFixa - impostoDeRenda;
                valorFinalRendaFixaImposto = totalRendaFixa + valorInvestido - impostoDeRenda;
                Console.WriteLine("Imposto de Renda: ");
                Console.WriteLine("");
                Console.WriteLine("Você pagara R$" + impostoDeRenda + " de imposto de renda");
                Console.WriteLine("O valor que renderá para renda fixa menos o imposto de renda será de R$" + valorRendaFixaImpostoRenda + ".");
                Console.WriteLine("O valor do seu investimento mais o seu valor aplicado menos o imposto será de R$" + valorFinalRendaFixaImposto + ".");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Opção de investimento: ");
                Console.WriteLine("");
                if (valorFinalPoupanca > valorFinalRendaFixaImposto)
                {
                    Console.WriteLine("A melhor opção de invesimentos é " + op1 + ".");
                }
                else
                {
                    Console.WriteLine("A melhor opção de investimento é " + op2 + ".");
                }
                Console.WriteLine("");
            }
            else if(meses > 25 && meses < 36)
            {
                impostoDeRenda = totalRendaFixa * 5 / 100;
                valorRendaFixaImpostoRenda = totalRendaFixa - impostoDeRenda;
                valorFinalRendaFixaImposto = totalRendaFixa + valorInvestido - impostoDeRenda;
                Console.WriteLine("Imposto de Renda: ");
                Console.WriteLine("");
                Console.WriteLine("Você pagara R$" + impostoDeRenda + " de imposto de renda");
                Console.WriteLine("O valor que renderá para renda fixa menos o imposto de renda será de R$" + valorRendaFixaImpostoRenda + ".");
                Console.WriteLine("O valor do seu investimento mais o seu valor aplicado menos o imposto será de R$" + valorFinalRendaFixaImposto + ".");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Opção de investimento: ");
                Console.WriteLine("");
                if (valorFinalPoupanca > valorFinalRendaFixaImposto)
                {
                    Console.WriteLine("A melhor opção de invesimentos é " + op1 + ".");
                }
                else
                {
                    Console.WriteLine("A melhor opção de investimento é " + op2 + ".");
                }
                Console.WriteLine("");
            }
            else if(meses > 36)
            {
                impostoDeRenda = totalRendaFixa * 1 / 100;
                valorRendaFixaImpostoRenda = totalRendaFixa - impostoDeRenda;
                valorFinalRendaFixaImposto = totalRendaFixa + valorInvestido - impostoDeRenda;
                Console.WriteLine("Imposto de Renda: ");
                Console.WriteLine("");
                Console.WriteLine("Você pagara R$" + impostoDeRenda + " de imposto de renda");
                Console.WriteLine("O valor que renderá para renda fixa menos o imposto de renda será de R$" + valorRendaFixaImpostoRenda + ".");
                Console.WriteLine("O valor do seu investimento mais o seu valor aplicado menos o imposto será de R$" + valorFinalRendaFixaImposto + ".");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Opção de investimento: .");
                Console.WriteLine("");
                if (valorFinalPoupanca > valorFinalRendaFixaImposto)
                {
                    Console.WriteLine("A melhor opção de invesimentos é " + op1 + ".");
                }
                else
                {
                    Console.WriteLine("A melhor opção de investimento é " + op2 + ".");
                }
                Console.WriteLine("");
            }
            */
            Console.ReadLine();
        }
    }
}
