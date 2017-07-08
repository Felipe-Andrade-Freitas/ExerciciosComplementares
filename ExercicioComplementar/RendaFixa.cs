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
        
        public void CalcularRendaFixa()
        {
            base.CalcularRendimento();
            this.CalcularImpostoDeRenda();
        }

        

        private void CalcularImpostoDeRenda()
        {
            if(QuantidadeMeses <= 12)
            {
                Imposto = ValorTotal - (RendimentoMensal * 0.25);
            }
            else if (QuantidadeMeses <= 24)
            {
                Imposto = ValorTotal - (RendimentoMensal * 0.15);
            }
            else if (QuantidadeMeses <= 36)
            {
                Imposto = ValorTotal - (RendimentoMensal * 0.05);
            }
            else if (QuantidadeMeses > 36)
            {
                Imposto = ValorTotal - (RendimentoMensal * 0.01);
            }
        }
    }
}
