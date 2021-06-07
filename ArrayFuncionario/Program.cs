using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar na main um vetor de 3 posiçções par cadastrar funcionarios e apresente-os.
            * Calcule e apresente o montante de salarios pago por esta empresa a estes funcionarios 
            * Crie e teste um mertodo para calcular aumento a partir de uma porcentagem digitada na main
            * Apresente novamente os atributos para ver os salarios alterados
            */
            Funcionario[] vetF = new Funcionario[3];
            for (int i = 0; i < vetF.Length; i++)
            {
                vetF[i] = new Funcionario();
                Console.Write("Digite o codigo do funcionario: ");
                vetF[i].codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o nome do funcionario: ");
                vetF[i].nome = Console.ReadLine();
                Console.Write("Digite o salario do funcionario: ");
                vetF[i].salario = Convert.ToDouble(Console.ReadLine());
            }
            foreach (Funcionario objF in vetF)
                objF.MostrarAtributos();
            Console.Write("Digite o porcentagem de aumento de funcionario: ");
            double percent = Convert.ToDouble(Console.ReadLine());
            foreach (Funcionario objF in vetF) // foreach serve para apresentar ou chamar metodos
            {
                objF.CalcularAumento(percent);
                objF.MostrarAtributos();
            }
            Console.ReadKey();
        }
    }
}
