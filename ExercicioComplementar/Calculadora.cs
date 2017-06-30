using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComplementar
{
    public class Calculadora
    {
        #region Variaveis

        public double ValorAplicado { get; set; }
        public int QuantMeses { get; set; }
        public double JurosMes { get; set; }
        public IList<double> ListaRendimento = new List<double>();
        public string op1 = "Poupança", op2 = "Renda Fixa";

        #endregion

        #region Metodos

        public void JurosCompostoPoupanca(double rendTotalPoupanca, double rendMensalPoupanca)
        {
            rendTotalPoupanca = ValorAplicado;

            for (int i = 1; i <= QuantMeses; i++)
            {
                rendMensalPoupanca = (rendTotalPoupanca * JurosMes) / 100;
                ListaRendimento.Add(rendMensalPoupanca);
                rendTotalPoupanca += rendMensalPoupanca;
            }
        }

        public void JurosCompostoRendaFixa(double rendTotalRendaFixa, double RendMensalRendaFixa)
        {
            rendTotalRendaFixa = ValorAplicado;
            for (int i = 0; i < QuantMeses; i++)
            {
                RendMensalRendaFixa = (rendTotalRendaFixa * JurosMes) / 100;
                rendTotalRendaFixa += RendMensalRendaFixa;
            }

            RendMensalRendaFixa = rendTotalRendaFixa - ValorAplicado;
        }

        public void ImpostoDeRenda(double impostoDeRenda, double rendMensalRendaFixaIpmosto)
        {
            if(QuantMeses <= 12)
            {
                impostoDeRenda = rendMensalRendaFixa * 0.25;
                RendMensalRendaFixaImposto = ValorAplicado - impostoDeRenda + rendMensalRendaFixaIpmosto;
            }
            else if(QuantMeses > 12 && QuantMeses <= 24 )
            {
                ImpostoDeRenda = RendMensalRendaFixa * 0.15;
                RendMensalRendaFixaImposto = ValorAplicado - ImpostoDeRenda + RendMensalRendaFixa;
            }
            else if(QuantMeses > 24 && QuantMeses <= 36)
            {
                ImpostoDeRenda = RendMensalRendaFixa * 0.5;
                RendMensalRendaFixaImposto = ValorAplicado - ImpostoDeRenda + RendMensalRendaFixa;
            }
            else if(QuantMeses > 36)
            {
                ImpostoDeRenda = RendMensalRendaFixa * 0.1;
                RendMensalRendaFixaImposto = ValorAplicado - ImpostoDeRenda + RendMensalRendaFixa;
            }
        }

        public void OpcaoDeInvestimento()
        {
            if(RendTotalPoupanca > RendMensalRendaFixaImposto)
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
            Console.WriteLine("O valor do rendimento da Poupança será de: R${0}", RendMensalPoupanca);
            Console.WriteLine("O valor do  retorno da Poupanca será de: R${0}", RendTotalPoupanca);
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("O valor do rendimento da Renda Fixa será de: R${0}\nO seu imposto de renda é: R${1}", RendMensalRendaFixa, ImpostoDeRenda);
            Console.WriteLine("O valor do retorno da Renda Fixa será de: R${0}", RendMensalRendaFixaImposto);
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            OpcaoDeInvestimento();
        }

        #endregion

        

    }
}
