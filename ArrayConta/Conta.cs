using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta
{
    class Conta
    {
        // decclaração dos atributos
        public int numero;
        public string titular;
        public double saldo;

        //declarar os metodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Numero: " + numero + "\tTitular: " + titular + "\tSaldo: " + saldo);
        }
    }
}
