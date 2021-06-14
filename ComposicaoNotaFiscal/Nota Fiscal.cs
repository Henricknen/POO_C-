using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    class NotaFiscal
    {
        public int NumeroNotaFiscal { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> Item { get; set; }

        public NotaFiscal(int numeroNotaFiscal, string data, List<ItemNotaFiscal> item)
        {
            NumeroNotaFiscal = numeroNotaFiscal;
            Data = data;
            Item = item;
        } 
        ~NotaFiscal()
        {
            Item = null;
            Console.WriteLine("Destrutor da Nota fiscal");
        }
    }
}
