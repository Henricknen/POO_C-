using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoContaCliente
{
    class Cliente
    {
        private string nome;
        private int rg;          //encapsulamento
        private int cpf;
        public void Mostrar()
        {
            Console.WriteLine("Nome: " + nome + "\tRg : " + rg + "\tCpf : " + cpf+"\n");
        }

        public string Nome
        {
            set                // realização do encapsulamento
            {
                this.nome = value;
            }
            get
            {
                return this.nome;
            }
        }
        public int Rg         // realização do encapsulamento
        {
            set
            {
                this.rg = value;
            }
            get
            {
                return this.rg;
            }
        }
        public int Cpf         // realização do encapsulamento
        {
            set
            {
                this.cpf = value;
            }
            get
            {
                return this.cpf;
            }
        }
    }
}
