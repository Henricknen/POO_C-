using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConta
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo     nome da variavel
            Conta       c1;                      //declara a ariavel c1 do tipo de dados Conta
            //new é alocação de memoria e conta() é o construtor da classe
            c1 = new Conta();                    // estou preparando a variavel para que ela possa se usada, ou seja
                                                 //ela esta sendo instanciada, agora ela se chama objeto
            c1.numero = 10;
            c1.titular = "Bia";
            c1.saldo = 100;
            c1.MostrarAtributos();  //.................................................................... chama o metodo que mostra os atributos
            c1.Sacar(10);
            c1.MostrarAtributos();

            // ou pode fazer assim
            Conta c2 = new Conta();     // instançiação
            c2.numero = 11;
            c2.titular = "Ana";
            c2.saldo = 200;
            c2.MostrarAtributos();  //................................................................... chama o metodo que mostra os atributos
            c2.Depositar(50);
            c2.MostrarAtributos();

            c1.TransferirDinheiro(10, c2);
            c1.MostrarAtributos();
            c2.MostrarAtributos();

            



            Conta c3 = new Conta();    // instançiação      // Classe inicia com letra maiscua
            Console.Write("informe o numero da conta: ");
            c3.numero = Convert.ToInt32(Console.ReadLine());// Objeto inicia com etra minuscula
            Console.Write("Informe o titular da conta: ");
            c3.titular = Console.ReadLine();                // Objeto inicia com etra minuscula
            Console.Write("Informe o saldo da conta: ");
            c3.saldo = Convert.ToDouble(Console.ReadLine());// Objeto inicia com etra minuscula
            c3.MostrarAtributos();  //..................................................................... chama o metodo que mostra os atributos
            c3.Sacar(100);
            c3.MostrarAtributos();
            c3.Depositar(1000);
            c3.MostrarAtributos();
            c2.TransferirDinheiro(10, c3);
            c2.MostrarAtributos();
            c3.MostrarAtributos();
            Console.ReadKey();             // Segura a janela do prompt
        }
    }
}
