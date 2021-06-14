using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoContaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente();
            Conta con1 = new Conta();
            con1.Numero = 1;
            con1.Saldo = 100;
            con1.Titular = cli1;   //esta é uma forma do atributo Titular receber uma instancia JA REALIZADA
            con1.Titular.Nome = "Lia";
            con1.Titular.Rg = 3445252;
            con1.Titular.Cpf = 4737858;
            con1.Mostrar();                  //mostroo conta e cliente no mesmo metodo

            Conta con2 = new Conta();
            con2.Numero = 2;
            con2.Saldo = 200;
            con2.Titular = new Cliente();    //esta é outra forma do atributo tituLar  SER INSTANCIADO
            con2.Titular.Nome = "Léo";
            con2.Titular.Rg = 33333;
            con2.Titular.Cpf = 24445;
            con2.Mostrar2();                //mostro os atributos da conta separado da classe cliente
            con2.Titular.Mostrar();
            Console.ReadKey();


        }
    }
}
