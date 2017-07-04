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
                JurosMensal = (ValorTotal * TaxaJuros) / 100;
                ValorTotal += JurosMensal;
                ListaRendimento.Add(JurosMensal);
            }
        }
    }
}
