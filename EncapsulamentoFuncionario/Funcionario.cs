using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    class Funcionario
    {
        //declarando atributos
        private int codigo;
        private string nome;
        private double salario;

        //declarei o metodo de encapsulamento do atributo codigo
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
        //declarei o metodo de encapsulamento do atributo nome
        public string Nome
        {
            set
            {
                this.nome = value;
            }
            get
            {
                return this.nome;
            }
        }
        //declarei o metodo de encapsulamento do atributo salario
        public double Salario
        {
            set
            {
                this.salario = value;
            }
            get
            {
                return this.salario;
            }
        }



        public void MostrarAtributos()
        {
            Console.WriteLine("Codigo: " + codigo + "\tNome: " + nome + "\tSalario: " + salario);
        }
    }
}
