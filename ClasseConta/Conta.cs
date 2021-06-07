using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConta
{
    class Conta
    {
        // delcaração dos atributos
        public int numero;
        public string titular;
        public double saldo;

        // declarar metodos
        public void TransferirDinheiro(double valor, Conta objetoConta) // passagem de parametro por"referncia"
        {
            if (valor <= saldo)
            {
                saldo = saldo - valor;
                objetoConta.saldo = objetoConta.saldo + valor;
            }
            else
                Console.WriteLine("Saldo insuficiente");
           
        }
        public void Sacar(double valorSaque)
        {
            if (valorSaque <= saldo)
                saldo = saldo - valorSaque;
            // saldo -= valorSaque
            else
                Console.WriteLine("Saldo insuficiente!");
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero + "\tTitular: " + titular + "\tSaldo: " + saldo);
        }
    }
}
