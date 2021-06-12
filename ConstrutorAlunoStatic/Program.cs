using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorAlunoStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Ana", 7, 7);
            Console.WriteLine("RA:" + Aluno.Ra);
            a1.Mostrar();
            Aluno a2 = new Aluno("Bia");
            Console.WriteLine("RA: " + Aluno.Ra);
            a2.Mostrar();
            Aluno a3 = new Aluno("Leo: ");
            Console.WriteLine("RA: " + Aluno.Ra);
            a3.Mostrar();
            Console.ReadKey();
        }
    }
}
