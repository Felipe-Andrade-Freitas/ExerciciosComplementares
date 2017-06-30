using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComplementar
{
    public class Poupanca : Investimento
    {
        public void CalculaPoupanca()
        {
            base.CalculaRendimento();
        }
    }
}
