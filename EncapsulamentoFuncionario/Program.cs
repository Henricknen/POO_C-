using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.Codigo = 10;
            f1.Nome = "Ana";
            f1.Salario = 1000; // metodo de dendo apresentado
            Console.WriteLine("Salario.....: " + f1.Salario);// metodo get sendo apresentado 
            if (f1.Salario > 100)
                f1.Salario = f1.Salario + 10;
            //f1.MostrarAtributos();

            Funcionario f2 = new Funcionario();
            Console.Write("Informe o codigo: ");
            f2.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Informe o salario: ");
            f2.Salario = Convert.ToDouble(Console.ReadLine());
            f2.MostrarAtributos();
            Console.ReadKey();
        }
    }
}
