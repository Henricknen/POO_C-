using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Comprador comp = new Comprador(1000);
            Vendedor vendedor = new Vendedor(10);
            Produto prod1 = new Produto(2, 50);
            Produto prod2 = new Produto(3, 55);
            Venda venda = new Venda(1, comp, vendedor);
            venda.VetProd = new List<Produto>();
            venda.VetProd.Add(prod1);
            venda.VetProd.Add(prod2);
            venda.Mostrar();
            Console.ReadKey();
        }
    }
}
