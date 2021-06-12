using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorAlunoStatic
{
    class Aluno
    {
        private static long ra;// O tipo ong é inteiro mas com mais digitos que o int
        private string nome;
        private double p1, p2;
        public static long Ra
        {
            get
            {
                return ra;
            }
        }

        public Aluno(string nome, double p1, double p2)
        {
            this.nome = nome;
            this.p1 = p1;
            this.p2 = p2;
            ra++;
        }
        public Aluno(string nome)
        {
            this.nome = nome;
            ra++;
        }
        public Aluno()
        {
            ra++;
        }
        static Aluno()
        {  //  No construtor static se pode inicializr um atributo estatico
            ra = 1570482111000;
        }
        public void Mostrar()
        {
            Console.WriteLine("Nome: " + nome + "\tP1: " + p1 + "\tP2: " + p2);
        }
    }
}
