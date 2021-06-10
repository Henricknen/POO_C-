using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            c1.Mostrar();
            Console.WriteLine("Informe o numero da conta:  ");
            c1.Numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o titular da conta:  ");
            c1.Titular = Console.ReadLine();
            Console.WriteLine("Informe o saldo da conta:  ");
            c1.Saldo = Convert.ToDouble(Console.ReadLine());

            Conta c2 = new Conta(103);
            c2.Mostrar();
            Console.WriteLine("Informe o titular da conta:  ");
            c2.Titular = Console.ReadLine();
            Console.WriteLine("Informe o saldo da conta:  ");
            c2.Saldo = Convert.ToDouble(Console.ReadLine());

            Conta c3 = new Conta(104, "lia");
            c3.Mostrar();
            Console.WriteLine("Informe o saldo da conta:  ");
            c3.Saldo = Convert.ToDouble(Console.ReadLine());

            Conta c4 = new Conta(105, "Bia", 100);
            c1.Mostrar();
            c2.Mostrar();
            c3.Mostrar();
            c4.Mostrar();
            Console.ReadKey();
        }
    }
}
