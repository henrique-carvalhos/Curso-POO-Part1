using System;
using System.Globalization;

namespace SalarioPOO_EX02
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto * (porcentagem / 100 + 1);
        }

        public override string ToString()
        {
            return Nome+ ", $ "+SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
