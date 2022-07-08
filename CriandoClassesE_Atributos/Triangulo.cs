using System;//Importação de dependencias.

namespace CriandoClassesE_Atributos//Namespace da Classe
{
    internal class Triangulo//Nome da classe.
    {
        public double A;//ATRIBUTOS DA CLASSE (TRIANGULO).
        public double B;
        public double C;
        //PUBLIC = esses atributos podem ser acessados em outro arquivo (programa principal nesse caso).
        //MÉTODO= Função dentro da classe (membro da classe)

        public double Area()//MÉTODO.
        //DOUBLE = TIPO DE DADO QUE O MÉTODO RETORNA.
        //AREA = NOME DO MÉTODO.
        //() = LISTA DE PARÂMETROS DO MÉTODO
        {
            //CORPO DO MÉTODO.
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //double Raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //return Raiz;
        }
    }
}
