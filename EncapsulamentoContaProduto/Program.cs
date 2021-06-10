using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoContaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            //ultiizei a formatação de string para numeros com formato de moeda para preço,
            //Ultiizei também para o atributo dataCadasttro a formmatação especifica
            Produto p1 = new Produto();
            Console.WriteLine("Digite o codigo do produto: ");
            p1.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o descrição do produto: ");
            p1.Descricao = Console.ReadLine();
            Console.WriteLine("Digite o quantidade do produto: ");
            p1.Quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto: ");
            p1.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Codigo: {p1.Codigo}\tDescrição: {p1.Descricao}" +
                    $"\tData de cadastro: {p1.DataCadastro} \nQuantidade: {p1.Quantidade} \tPreço: {p1.Preco:C}");
            Console.ReadKey();
        }
    }
}
