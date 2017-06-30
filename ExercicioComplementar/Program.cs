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
            Calculadora calc = new Calculadora();
            
            void EntradaDeDados()
            {
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Valor a ser aplicado: R$");
                calc.valorAplicado = double.Parse(Console.ReadLine());
                Console.Write("Quantidade de Meses a ser aplicado: ");
                calc.quantMeses = int.Parse(Console.ReadLine());
                Console.Write("Taxa de Juros Poupança: ");
                calc.jurosMesPoupanca = double.Parse(Console.ReadLine());
                Console.Write("Taxa de Juros Renda Fixa: ");
                calc.jurosMesRendaFixa = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------");
            }

            EntradaDeDados();
            calc.JurosCompostoPoupanca();
            calc.JurosCompostoRendaFixa();
            calc.ImpostoDeRenda();
            calc.Resposta();
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
