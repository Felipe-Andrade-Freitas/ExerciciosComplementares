using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis

            double valorAplicado, rendPoupanca, quantMeses;
            double jurosCompPoupanca = 0;

            #endregion

            //Entrada de Dados
            Console.Write("Qual o valor a ser aplicado? R$");
            valorAplicado = double.Parse(Console.ReadLine());
            Console.Write("Qual a porcentagem dos rendimentos mensais para poupaca? ");
            rendPoupanca = double.Parse(Console.ReadLine());
            //Console.Write("Qual a porcentagem dos rendimentos mensais para renda fixa? ");
            //rendaFixa = double.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de meses que o dinheiro ficará aplicado? ");
            quantMeses = int.Parse(Console.ReadLine());

            #region Poupança
            for (double x = 0; x <= quantMeses; x++)
            {
                jurosCompPoupanca = valorAplicado * rendPoupanca * quantMeses / 100;
            }

            jurosCompPoupanca += valorAplicado;

            Console.WriteLine("O valor a receber é: {0}", jurosCompPoupanca);
            #endregion
            Console.ReadLine();
        }
    }
}
