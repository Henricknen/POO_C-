using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta[] vetConta = new Conta[3]; //declarando um vetor de 5 posições
            for (int i = 0; i < vetConta.Length; i++)
            {
                vetConta[i] = new Conta();   // instanciando uma unica posição do valor
                Console.Write("Digite o numero da conta: ");
                vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o titular da conta: ");
                vetConta[i].titular = Console.ReadLine();
                Console.Write("Digite o saldo da conta: ");
                vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
            }
            foreach (Conta c in vetConta)
                c.MostrarAtributos();
            Console.ReadKey();
        }
    }
}
