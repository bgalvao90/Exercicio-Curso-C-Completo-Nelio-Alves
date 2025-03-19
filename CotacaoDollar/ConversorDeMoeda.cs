using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDollar
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;
        public static double CotacaoDollar(double dollar, double valor)
        {
            return dollar * valor + (dollar * valor * IOF / 100);
        }
    }
}
