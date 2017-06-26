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
            double valorInvestido, Poupanca, rendaFixa;
            int meses;

            //Variáveis relacionado a Poupança
            double TotalPoupanca, valorFinalPoupanca;
            string op1 = "Poupança";

            //Variáveis relacionado a Renda Fixa
            double TotalRendaFixa;
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
            valorInvestido = double.Parse(Console.ReadLine());
            Console.Write("Qual a porcentagem dos rendimentos mensais para poupaca? ");
            Poupanca = double.Parse(Console.ReadLine());
            Console.Write("Qual a porcentagem dos rendimentos mensais para renda fixa? ");
            rendaFixa = double.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de meses que o dinheiro ficará aplicado? ");
            meses = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Saida de Dados

            //Poupança
            Console.WriteLine("Poupança: ");
            Console.WriteLine("");
            TotalPoupanca = Poupanca * valorInvestido * meses / 100;
            valorFinalPoupanca = TotalPoupanca + valorInvestido;
            Console.WriteLine("O valor que renderá para poupanca será de R$" + TotalPoupanca + ".");
            Console.WriteLine("O valor do seu investimento mais o seu valor aplicado será de R$" + valorFinalPoupanca + ".");
            Console.WriteLine("");
            Console.WriteLine("");
            
            //Renda Fixa
            Console.WriteLine("Renda Fixa: ");
            Console.WriteLine("");
            TotalRendaFixa = rendaFixa * valorInvestido * meses / 100;
            valorFinalRendaFixa = TotalRendaFixa + valorInvestido;
            Console.WriteLine("O valor que renderá para renda fixa será de R$" + valorFinalRendaFixa);
            Console.WriteLine("");
            Console.WriteLine("");

            //Imposto de Renda
            if(meses <= 12)
            {
                impostoDeRenda = TotalRendaFixa * 25 / 100;
                valorRendaFixaImpostoRenda = TotalRendaFixa - impostoDeRenda;
                valorFinalRendaFixaImposto = TotalRendaFixa + valorInvestido - impostoDeRenda;
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
                impostoDeRenda = TotalRendaFixa * 15 / 100;
                valorRendaFixaImpostoRenda = TotalRendaFixa - impostoDeRenda;
                valorFinalRendaFixaImposto = TotalRendaFixa + valorInvestido - impostoDeRenda;
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
                impostoDeRenda = TotalRendaFixa * 5 / 100;
                valorRendaFixaImpostoRenda = TotalRendaFixa - impostoDeRenda;
                valorFinalRendaFixaImposto = TotalRendaFixa + valorInvestido - impostoDeRenda;
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
                impostoDeRenda = TotalRendaFixa * 1 / 100;
                valorRendaFixaImpostoRenda = TotalRendaFixa - impostoDeRenda;
                valorFinalRendaFixaImposto = TotalRendaFixa + valorInvestido - impostoDeRenda;
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

            Console.ReadLine();
        }
    }
}
