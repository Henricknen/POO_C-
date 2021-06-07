using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            Console.Write("Cadatre um numero de conta: ");
            c1.Numero = Convert.ToInt32(Console.ReadLine()); //set
            Console.Write("Cadatre um titular da conta: ");
            c1.Titular = Console.ReadLine(); //set
            Console.Write("Cadatre um saldo de conta: ");
            c1.Saldo = Convert.ToDouble(Console.ReadLine()); //set

            Conta c2 = new Conta();
            Console.Write("Cadatre um numero de conta: ");
            c1.Numero = Convert.ToInt32(Console.ReadLine()); //set
            Console.Write("Cadatre um titular da conta: ");
            c1.Titular = Console.ReadLine(); //set
            Console.Write("Cadatre um saldo de conta: ");
            c1.Saldo = Convert.ToDouble(Console.ReadLine()); //set

                                                             //get                        //get                   //get                    //get
            Console.WriteLine("Numero: " + c1.Numero + "\tTitular: " + c1.Titular + "\tSaldo: " + c1.Saldo);
            Console.WriteLine("Numero: " + c2.Numero + "\tTitular: " + c2.Titular + "\tSaldo: " + c2.Saldo);
            Console.ReadKey();
        }
    }
}
