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
        public int valorAplicado = 0, rendPoupanca = 0, rendRendaFixa = 0, quantMeses = 0;
        public double jurosPoupanca = 0, jurosRendaFixa = 0, impostoDeRenda = 0, totJurosImposto = 0;
        string op1 = "Poupança", op2 = "Renda Fixa";

        
        public void JurosPoupanca()
        {
            jurosPoupanca = valorAplicado;

            for(int x = 1; x <= quantMeses; x ++)
            {
                jurosPoupanca += jurosPoupanca * rendPoupanca / 100;
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
            MessageBox.Show("O valor do rendimento para Poupança será de: " + jurosPoupanca + "\n\nO valor do rendimento para Renda Fixa será de: " + jurosRendaFixa + "\n\nO valor dos impostos de renda será de: " + impostoDeRenda + "\n\nO valor do rendimento para Renda Fixa - Imposto de Renda será de: " + totJurosImposto);
        }

        public void MelhorOpcao()
        {
                if (jurosPoupanca > totJurosImposto)
                {
                    MessageBox.Show("A melhor opção de invesimentos é " + op1 + ".");
                }
                else
                {
                    MessageBox.Show("A melhor opção de investimento é " + op2 + ".");
                }
        }
    }
}
