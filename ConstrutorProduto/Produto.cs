using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    class Produto
    {
        private int codigo;
        private string descricao;
        private double preco;
        private static int contador;

        public static int Contador
        {
            get
            {
                return contador;
            }
        }
        public Produto(int codigo, string descricao, double preco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
            contador = contador + 1;
        }

        public Produto(string descricao)
        {
            this.descricao = descricao;
            contador += 1;
        }


        //declaração dos metodos
        public void Mostrar()
        {
            Console.WriteLine("Codigo: " + codigo + "\tDescrição: " + descricao + "\tPreço: " + preco);
        }
    }
}
