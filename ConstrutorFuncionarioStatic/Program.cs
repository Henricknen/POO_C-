using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorFuncionarioStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario(1, "Ana",1000);
            Funcionario f2 = new Funcionario(2, "Bia", 2000);
            Funcionario f3 = new Funcionario(2, "Lia");
            Funcionario f4 = new Funcionario();
            Console.WriteLine("Quantidade de instancias? " + Funcionario.Contador);
            Console.ReadKey();



        }
    }
}
