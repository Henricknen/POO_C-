using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorFuncionarioStatic
{
    class Funcionario
    {
        //declarando atributos
        private int codigo;
        private string nome;
        private double salario;
        private static int contador;

        //metodo construtor
        public Funcionario(int codigo, string nome, double salario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
            contador = contador + 1; //incremento de instancias
        }
        public Funcionario(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            contador++; //incremento de instancias
        }
        public Funcionario()
        {
            contador += 1; //incremento de instancias
        }
        //metodo de encapsualmnto do atributo static
        public static int Contador
        {
            get
            {
                return contador;
            }
        }
    }
}
