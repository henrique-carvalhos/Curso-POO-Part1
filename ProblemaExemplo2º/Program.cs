using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProblemaExemplo2º
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();//Variável composta (nome,preço,quantidade).

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();//Acessa o PRODUTO "P" e armazena na variável Nome.

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);//Acessa o PRODUTO "P" e armazena na variável Preço.

            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());//Acessa o PRODUTO "P" e armazena na variável Quantidade.

            Console.WriteLine();
            Console.WriteLine("Dados do produto: "+ p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: "+p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.ReadKey();
        }
    }
}
