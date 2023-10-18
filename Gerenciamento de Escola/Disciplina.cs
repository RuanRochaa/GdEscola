using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{
    public class Disciplina
    {
            public string Titulo { get; set; }
            public int CargaHoraria { get; set; }
            public string Ementa { get; set; }
        public string? CodigoDisciplina { get; internal set; }

        public Disciplina(string titulo, int cargaHoraria, string ementa)
            {
                Titulo = titulo;
                CargaHoraria = cargaHoraria;
                Ementa = ementa;
            }

        internal void AtribuirProfessor(Professor professor)
        {
            throw new NotImplementedException();
        }
    }
}
