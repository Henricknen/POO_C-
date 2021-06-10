using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisão_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            double AreaCirculo = 0;
            double RaioDoCirculo = 0;
            Console.Write("Informe o raio do circulo: ");     //input
            RaioDoCirculo = Convert.ToDouble(Console.ReadLine());
            AreaCirculo = Math.PI * Math.Pow(RaioDoCirculo, 2);
            Console.WriteLine("A area do circulo de raio " + RaioDoCirculo + " é " + AreaCirculo);
            if (AreaCirculo > 1000)
                Console.WriteLine("Area grande");
            else if (AreaCirculo > 300 && AreaCirculo < 700)  // elif
                Console.WriteLine("Area intermediaria");
            else
                Console.WriteLine("AArea pequena");
            int i = 0;
            for ( i = 0; i < 5; i++)                      // " for i in range(5) "
                Console.WriteLine(i);
            while (i < 10)
            {
                Console.WriteLine(i);
                i = i + 1;

            }
            Console.ReadKey();                                // Segura a tela do prompt
        }
    }
}


                                                               // \t - da um espaço (tabulação)
                                                               // \n - faz uma quebra de linha na frase