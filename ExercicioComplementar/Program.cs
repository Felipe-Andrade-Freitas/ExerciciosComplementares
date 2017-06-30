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
            Poupanca poup = new Poupanca();
            RendaFixa rendaFixa = new RendaFixa();
            
            void EntradaDeDados()
            {
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Valor a ser aplicado: R$");
                calc.ValorAplicado = double.Parse(Console.ReadLine());
                Console.Write("Quantidade de Meses a ser aplicado: ");
                calc.QuantMeses = int.Parse(Console.ReadLine());
                Console.Write("Taxa de Juros Poupança: ");
                calc.JurosMes = double.Parse(Console.ReadLine());
                Console.Write("Taxa de Juros Renda Fixa: ");
                calc.JurosMes = double.Parse(Console.ReadLine());
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
