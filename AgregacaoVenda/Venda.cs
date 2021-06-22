using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    class Venda
    {
        public int NumVenda { get; set; }
        public Comprador C { get; set; }
        public Vendedor V { get; set; }
        public List<Produto> VetProd { get; set; }

        public Venda(int numVenda, Comprador c, Vendedor v)
        {
            NumVenda = numVenda;
            C = c;
            V = v;
        }
        public void Mostrar()
        {
            Console.WriteLine("Numero da venda: " + NumVenda +
                "\tComissão do vendedor: " + V.Comissao +
                "\tVerba do comprador: " + C.Verba);
            foreach (Produto p in VetProd)
                Console.WriteLine("Tamanho: " + p.Tamanho + "\tPreço: " + p.Preco);
        }
    }
}
