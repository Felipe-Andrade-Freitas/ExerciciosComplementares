using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeciciosComplemetares
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void jurosCompostoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Investimento calc = new Investimento();

            calc.valorAplicado = int.Parse(txtValorAplicado.Text);
            calc.rendPoupanca = int.Parse(txtJurosPoupanca.Text);
            calc.rendRendaFixa = int.Parse(txtJurosRendaFixa.Text);
            calc.quantMeses = int.Parse(txtQuantMeses.Text);
            calc.JurosPoupanca();
            calc.JurosRendaFixa();
            calc.ImpostoDeRenda();
            calc.TotJurosImposto();
            calc.Respostas();
            calc.MelhorOpcao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
