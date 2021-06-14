using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoContaCliente
{
    class Conta
    {
        private int numero;
        private Cliente titular; //agregação a classe Conta estará relacionada com a classe Cliente, por meio do atributo "private Ciente titular"
        private double saldo;
        public void Mostrar()
        {
            Console.WriteLine("Numero: " + numero + "\tSaldo: " + saldo + "\tTitular: ");
            titular.Mostrar();
        }
        public void Mostrar2()
        {
            Console.WriteLine("Numero: " + numero + "\tSaldo: " + saldo);
        }
        public int Numero   //encapsulamento
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
        public Cliente Titular   //encapsulamento
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
        public double Saldo   //encapsulamento
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
