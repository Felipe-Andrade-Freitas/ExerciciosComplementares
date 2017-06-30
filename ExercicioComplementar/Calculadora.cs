using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComplementar
{
    class Calculadora
    {
        #region Variaveis

        public double valorAplicado { get; set; }
        public int quantMeses { get; set; }
        public double jurosMesPoupanca { get; set; }
        public double jurosMesRendaFixa { get; set; }
        public double rendMensalPoupanca { get; set; }
        public double rendTotalPoupanca { get; set; }
        public double rendMensalRendaFixa { get; set; }
        public double rendMensalRendaFixaImposto { get; set; }
        public double rendTotalRendaFixa { get; set; }
        public double impostoDeRenda { get; set; }
        public string op1 = "Poupança", op2 = "Renda Fixa";

        #endregion

        #region Metodos

        public void JurosCompostoPoupanca()
        {
            for (int i = 0; i < quantMeses; i++)
            {
                rendMensalPoupanca = (valorAplicado * jurosMesPoupanca * quantMeses) / 100;
            }

            rendTotalPoupanca = valorAplicado + rendMensalPoupanca;
        }

        public void JurosCompostoRendaFixa()
        {
            for (int i = 0; i < quantMeses; i++)
            {
                rendMensalRendaFixa = (valorAplicado * quantMeses * jurosMesRendaFixa) / 100;
                rendTotalRendaFixa = valorAplicado + rendMensalRendaFixa;
            }

        }

        public void ImpostoDeRenda()
        {
            if(quantMeses <= 12)
            {
                impostoDeRenda = rendMensalRendaFixa * 0.25;
                rendMensalRendaFixaImposto = valorAplicado - impostoDeRenda + rendMensalRendaFixa;
            }
            else if(quantMeses > 12 && quantMeses <= 24 )
            {
                impostoDeRenda = rendMensalRendaFixa * 0.15;
                rendMensalRendaFixaImposto = valorAplicado - impostoDeRenda + rendMensalRendaFixa;
            }
            else if(quantMeses > 24 && quantMeses <= 36)
            {
                impostoDeRenda = rendMensalRendaFixa * 0.5;
                rendMensalRendaFixaImposto = valorAplicado - impostoDeRenda + rendMensalRendaFixa;
            }
            else if(quantMeses > 36)
            {
                impostoDeRenda = rendMensalRendaFixa * 0.1;
                rendMensalRendaFixaImposto = valorAplicado - impostoDeRenda + rendMensalRendaFixa;
            }
        }

        public void OpcaoDeInvestimento()
        {
            if(rendTotalPoupanca > rendMensalRendaFixaImposto)
            {
                Console.WriteLine("A melhor opção para investimento é: {0}", op1);
            }
            else
            {
                Console.WriteLine("A melhor opção para investimento é: {0}", op2);
            }
        }
        
        public void Resposta()
        {
            Console.WriteLine("");
            Console.WriteLine("O valor do rendimento da Poupança será de: R${0}", rendMensalPoupanca);
            Console.WriteLine("O valor do  retorno da Poupanca será de: R${0}", rendTotalPoupanca);
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("O valor do rendimento da Renda Fixa será de: R${0}\nO seu imposto de renda é: R${1}", rendMensalRendaFixa, impostoDeRenda);
            Console.WriteLine("O valor do retorno da Renda Fixa será de: R${0}", rendMensalRendaFixaImposto);
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            OpcaoDeInvestimento();
        }

        #endregion

        

    }
}
