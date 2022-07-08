using System;
using System.Globalization;

namespace CriandoClassesE_Atributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;//Triangulo virou um TIPO, ex: double, int.,declaração de variáveis.
            x = new Triangulo();//instanciação = aponta para o objeto da classe(A,B,C).
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do tringulo X:");
            x.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Acessar atributo (x.A), amarzenar no atributo(campos) A do objeto composto X.  
            x.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do tringulo y:");
            y.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            //RETORNA TRIANGILO "X" COM A OPERAÇÃO "AREA".
            //"()" PARA INDICAR QUE É UM MÉTODO.

            double areaY = y.Area();

            Console.WriteLine("Área de x igual á :" + areaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y igual á :" + areaY.ToString("f4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

            Console.Read();
        }
    }
}
