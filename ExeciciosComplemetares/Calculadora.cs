using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeciciosComplemetares
{
    class Calculadora
    {
        public int valorAplicado, rendPoupanca, rendRendaFixa, quantMeses;
        public double jurosPoupanca, jurosRendaFixa, impostoDeRenda, totJurosImposto;

        public void JurosPoupanca()
        {
            for(int x = 0; x <= quantMeses; x ++)
            {
                jurosPoupanca = valorAplicado * rendPoupanca * quantMeses / 100;
            }
        }

        public void JurosRendaFixa()
        {
            for(int x = 0; x <= quantMeses; x ++)
            {
                jurosRendaFixa = valorAplicado * rendRendaFixa * quantMeses / 100;
            }
        }

        public void ImpostoDeRenda()
        {
            if (quantMeses <= 12)
            {
                impostoDeRenda = jurosRendaFixa * 0.25;
            }
            else if (quantMeses >= 13 && quantMeses <= 24)
            {
                impostoDeRenda = jurosRendaFixa * 0.15;
            }
            else if(quantMeses >= 25 && quantMeses <= 36)
            {
                impostoDeRenda = jurosRendaFixa * 0.5;
            }
            else if(quantMeses > 36)
            {
                impostoDeRenda = jurosRendaFixa * 0.1;
            }
        }

        public void TotJurosImposto()
        {
            totJurosImposto = jurosRendaFixa - impostoDeRenda;
        }

        public void Respostas()
        {
            MessageBox.Show("O valor do rendimento para Poupança será de: " + jurosPoupanca);
            MessageBox.Show("O valor do rendimento para Renda Fixa será de: " + jurosRendaFixa);
            MessageBox.Show("O valor dos impostos de renda será de: " + impostoDeRenda);
            MessageBox.Show("O valor do rendimento para Renda Fixa - Imposto de Renda será de: " + totJurosImposto);
        }
    }
}
