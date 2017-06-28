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

        private void button1_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();

            calc.valorAplicado = 1000;
            calc.rendPoupanca = 10;
            calc.rendRendaFixa = 10;
            calc.quantMeses = 12;
            calc.JurosPoupanca();
            calc.JurosRendaFixa();
            calc.ImpostoDeRenda();
            calc.TotJurosImposto();
            calc.Respostas();
        }
    }
}
