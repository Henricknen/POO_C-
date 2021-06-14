using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemNotaFiscal it1 = new ItemNotaFiscal(10);
            ItemNotaFiscal it2 = new ItemNotaFiscal(20);
            List<ItemNotaFiscal> lista = new List<ItemNotaFiscal>();
            lista.Add(it1);
            lista.Add(it2);
            NotaFiscal nf = new NotaFiscal(1, "13/06/2021", lista);//Lista representa a composição
            nf = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}
