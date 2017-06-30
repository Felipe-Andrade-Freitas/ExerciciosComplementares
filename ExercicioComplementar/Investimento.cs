using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComplementar
{
    public class Investimento
    {
        #region Variaveis

        public double ValorAplicado { get; set; }
        public int QuantMeses { get; set; }
        public double TaxaJuros { get; set; }
        public double ValorTotal { get; set; }
        public double JurosMensal { get; set; }
        public string MelhorInvestimento { get; set; }
        public double ValorMaior { get; set; }
        public IList<double> ListaRendimento = new List<double>();

        #endregion
        
        public void CalculaRendimento()
        {
            ValorTotal = ValorAplicado;

            for (int i = 1; i <= QuantMeses; i++)
            {
                ValorTotal += (ValorTotal * TaxaJuros) / 100;
                ListaRendimento.Add(JurosMensal);
            }
        }

        public void Opcao(Poupanca poupanca, RendaFixa rendaFixa, double imposto)
        {
            if (poupanca.ValorTotal > rendaFixa.ValorTotal)
            {
                MelhorInvestimento = "Poupança";
                ValorMaior = poupanca.ValorTotal - rendaFixa.ValorTotal;
            }
            else if (poupanca.ValorTotal < rendaFixa.ValorTotal)
            {
                MelhorInvestimento = "Renda Fixa";
                ValorMaior = poupanca.ValorTotal - imposto;
            }
            else
            {
                MelhorInvestimento = "Valores iguais";
            }
        }
    }
}
