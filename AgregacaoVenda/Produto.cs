using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    class Produto
    {
        public int Tamanho { get; set; }
        public double Preco { get; set; }

        public Produto(int tamanho, double preco)
        {
            Tamanho = tamanho;
            Preco = preco;
        }
    }
}
