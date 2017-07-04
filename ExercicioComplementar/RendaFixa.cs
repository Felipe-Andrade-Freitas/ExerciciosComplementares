using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComplementar
{
    public class RendaFixa : Investimento
    {
        public double Imposto { get; set; }
        
        public void CalculaRendaFixa()
        {
            base.CalculaRendimento();
            this.ImpostoDeRenda();
        }

        private void ImpostoDeRenda()
        {
            if(QuantMeses <= 12)
            {
                Imposto = ValorTotal - (ValorTotal * 0.25);
            }
            else if (QuantMeses <= 24)
            {
                Imposto = ValorTotal - (ValorTotal * 0.15);
            }
            else if (QuantMeses <= 36)
            {
                Imposto = ValorTotal - (ValorTotal * 0.05);
            }
            else if (QuantMeses > 36)
            {
                Imposto = ValorTotal - (ValorTotal * 0.01);
            }
        }
    }
}
