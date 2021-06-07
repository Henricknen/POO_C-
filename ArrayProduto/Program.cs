using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] vetP = new Produto[3];
            for (int i = 0; i < vetP.Length; i++)
            {
                vetP[i] = new Produto();
                Console.Write("Digite o codigo do produto: ");
                vetP[i].codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a descrição do produto: ");
                vetP[i].descricao = Console.ReadLine();
                Console.Write("Digite o quantidade do produto: ");
                vetP[i].quantidade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o preço do produto: ");
                vetP[i].preco = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Digite a porcentagem do produto: ");
            double percent = Convert.ToDouble(Console.ReadLine());
            foreach (Produto p in vetP)
            {
                p.MostrarAtributos();
                p.CalcularAumento(percent);
                p.MostrarAtributos();
            }
            for (int i= 0; i < vetP.Length; i++)
            {
                Console.Write("Quantos " + vetP[i].descricao + " voçê quer compar");
                int qtde = Convert.ToInt32(Console.ReadLine());
                vetP[i].AlterarEstoque(qtde);
            }
            Console.WriteLine("\n\nPosição do estoque atualizado...");
            foreach (Produto p in vetP)
                p.MostrarAtributos();
            Console.ReadKey();
        }
    }
}
