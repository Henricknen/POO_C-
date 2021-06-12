using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("mouse");
            Produto p2 = new Produto("fone");
            Produto p3 = new Produto(1,"Monitor",570);
            Produto p4 = new Produto(2,"teclado",150);
            Console.WriteLine("Quantidade de instancias: " + Produto.Contador);
            p1.Mostrar();
            p2.Mostrar();
            p3.Mostrar();
            p4.Mostrar();
            Console.ReadKey();
        }
    }
}
