using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    class Conta
    {
        //declaração dos atributos encapsulados
        private int numero;
        private string titular;
        private double saldo;


        // criaçãodo metodo de encapsulamento
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
