using System;
using System.Globalization;

namespace ExemploMembrosEstaticos
{
    internal class Calculadora
    {
        //Public para poder ser chamada em qualquer lugar, static por conta de ser uma função estática.
        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(3.0, r);
        }
    }
}
