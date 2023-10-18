using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{
    internal class Curso
    {
        private string nomeCurso;
        public string NomeCurso
        {
            get { return nomeCurso; }
            set { nomeCurso = value; }
        }

        private int idCurso;
        public int IDCurso
        {
            get { return IDCurso; }
            set { IDCurso = value; }
        }
        public List<Aluno> AlunosMatriculados { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public object Nome { get; internal set; }
        public object CodigoCurso { get; internal set; }

        public Curso(string nomeCurso, int iDCurso)
        {
            this.nomeCurso = nomeCurso;
            this.IDCurso = iDCurso;
            AlunosMatriculados = new List<Aluno>();
            Disciplinas = new List<Disciplina>();

        }
        public void MatricularAluno(Aluno aluno)
        {
            AlunosMatriculados.Add(aluno);
        }

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }



    }
}
