using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    class Vendedor
    {
        public double Comissao { get; set; }

        public Vendedor(double comissao)
        {
            Comissao = comissao;
        }
    }
}
