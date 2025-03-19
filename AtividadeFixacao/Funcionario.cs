using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AtividadeFixacao
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

        public double AumentarSalario(double porcentagem)
        {
            return SalarioBruto += SalarioBruto * porcentagem / 100;
        }


    }
}
