using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProduto
{
    class Produto
    {
        // declaração de atributos
        public int codigo;
        public string descricao;
        public double preco;

        //declaração de metodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Codigo: " + codigo + "\tDecrição" + descricao + "\tPreço: " + preco);
        }
    }
}
