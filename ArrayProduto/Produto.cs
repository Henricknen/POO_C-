using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProduto
{
    class Produto
    {
        // declaração dos atributos
        public int codigo;
        public string descricao;
        public int quantidade;
        public double preco;

        // declaralção dos metodos
        public void MostrarAtributos()
        { 
            Console.WriteLine("Codigo: " + codigo + "\tDescrição: " + descricao + "\tQuantidade: " + quantidade + "\tPreço: " + preco);
        }
        public void CalcularAumento(double percentagem)
        {
            preco = preco + (preco * percentagem / 100);
        }
        public void AlterarEstoque(int quantidadeVendida)
        {
            if (quantidadeVendida <= quantidade)
                quantidade -= quantidadeVendida;
            else
                Console.WriteLine("Não a estoque suficiente");
            if (quantidade <= 5)
                Console.WriteLine("Abasteça o estoque");
        }

    }
}
