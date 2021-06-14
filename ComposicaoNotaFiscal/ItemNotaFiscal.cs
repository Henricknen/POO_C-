using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    class ItemNotaFiscal
    {
        public int QtdeProduto { get; set; }

        public ItemNotaFiscal(int qtdeProduto)
        {
            QtdeProduto = qtdeProduto;
        }
        ~ItemNotaFiscal()
        {
            Console.WriteLine("Destrutor do item da nota fiscal");
        }
    }
}
