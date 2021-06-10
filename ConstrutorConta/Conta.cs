using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    class Conta
    {
        //ddeclração os atributos
        private int numero;
        private string titular;
        private double saldo;

        //declaração dos metodos construtores
        public Conta()/// Construtor padrao
        {

        }
        public Conta(int numero)
        {
            this.numero = numero;
        }
        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
        }
        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }
        public void Mostrar() //decaração de uma função normal
        {
            Console.WriteLine("Numero: " + numero + "\tTitular: " + titular + "\tSaldo: " + saldo);
        }
        public int Numero
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }
        public string Titular
        {
            set
            {
                this.titular = value;
            }
            get
            {
                return this.titular;
            }
        }
        public double Saldo 
        {
            set
            {
                this.saldo = value;
            }
            get
            {
                return this.saldo;
            }
        }
    }
}
