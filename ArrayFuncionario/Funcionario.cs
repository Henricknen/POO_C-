using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    class Funcionario
    {
        //declaração de atributos
        public int codigo;
        public string nome;
        public double salario;

        //declaração dos metodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Codigo: " + codigo + "\tNome: " + nome + "\tSalario: " + salario);
        }
        public void CalcularAumento(double porcentagem)
        {
            salario += salario * porcentagem / 100;
        }
       
    }
}
