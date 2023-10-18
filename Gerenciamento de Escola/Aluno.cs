using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{
    internal class Aluno : Pessoa
    {
        private string curso;
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        private int matricula;
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public List<Curso> CursosMatriculados { get; set; }
        public Aluno(string nome, int idade, string endereco, int celular, string curso, int matricula) : base(nome, idade, endereco, celular)
        {
            this.curso = curso;
            this.matricula = matricula;
            CursosMatriculados = new List<Curso>();
        }
        public void MatricularEmCurso(Curso curso)
    {
        CursosMatriculados.Add(curso);
    }

        public Aluno(string nome, int idade, string endereco, int celular, int matricula, string? curso) : base(nome, idade, endereco, celular)
        {
        }

        public void InfoAluno()
        {
            Console.WriteLine("O aluno(a)" + Nome + " de " + Idade + " anos, está cursando" + curso + " e sua matricula é " + matricula);
        }

    }
}
