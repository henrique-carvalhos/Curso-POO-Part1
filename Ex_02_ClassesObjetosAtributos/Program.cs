using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_02_ClassesObjetosAtributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Duas formas de instanciar uma classe.
              Funcionario f1, f2;
              f1 = new Funcionario();
              f2 = new Funcionario();*/
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.NomeFuncionario = Console.ReadLine();
            Console.Write("Salário:");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.NomeFuncionario = Console.ReadLine();
            Console.Write("Salário:");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (f1.Salario + f2.Salario) / 2.0;
            Console.WriteLine("Salário médio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
