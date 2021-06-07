using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(); // instancia de objeto
            Console.Write("Digite o codigo do produto: ");
            p1.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a descrição do produto: ");
            p1.descricao = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            p1.preco = Convert.ToDouble(Console.ReadLine());

            Produto p2 = new Produto(); // instancia de objeto
            Console.Write("Digite o codigo do produto: ");
            p2.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diite a descrição do produto: ");
            p2.descricao = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            p2.preco = Convert.ToDouble(Console.ReadLine());

            p1.MostrarAtributos();
            p2.MostrarAtributos();
            double soma = p1.preco + p2.preco;
            Console.WriteLine("Total dos produtos é: " + soma);
            Console.ReadKey();
        }
    }
}
