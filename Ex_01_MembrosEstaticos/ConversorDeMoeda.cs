using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_MembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.00 / 100.00 + 1.00;

        public static double DolarParaReal(double cot, double comp)
        {
            return cot * comp * Iof;
        }
    }
}
