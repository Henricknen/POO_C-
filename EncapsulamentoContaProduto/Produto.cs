using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoContaProduto
{
    class Produto
    {
        private int codigo;
        private string descricao;
        private DateTime dataCadastro = System.DateTime.Now;
        private int quantidade;
        private double preco;

        public int Codigo
        {
            set
            {
                this.codigo = value;
            }
            get
            {
                return this.codigo;
            }
        }
        public string Descricao
        {
            set
            {
                this.descricao = value;
            }
            get
            {
                return this.descricao;
            }
        }
        public int Quantidade
        {
            set
            {
                this.quantidade = value;
            }
            get
            {
                return this.quantidade;
            }
        }
        public double Preco
        {
            set
            {
                this.preco = value;
            }
            get
            {
                return this.preco;
            }
        }
            public DateTime DataCadastro
        {
            get
            {
                return this.dataCadastro;
            }
        }
    }
    
}
