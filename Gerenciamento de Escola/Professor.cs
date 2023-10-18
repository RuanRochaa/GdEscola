using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{
    internal class Professor : Pessoa
    {
        private int salario;
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        private string lecionando;
        public string Lecionando
        {
            get { return lecionando; }
            set { lecionando = value; }
        }
        public List<Disciplina> DisciplinasLecionadas { get; set; }

        public Professor(string? nome, int idade, string endereco, int celular, int salario, string lecionando) : base(nome, idade, endereco, celular)
        {
            this.lecionando = lecionando;
            this.salario = salario;
            DisciplinasLecionadas = new List<Disciplina>();

        }



        public void AtribuirDisciplina(Disciplina disciplina)
        {
            DisciplinasLecionadas.Add(disciplina);
        }

        public void InfoProfessor()
        {
            Console.WriteLine("O professor(a)" + Nome + " tem " + Idade + "anos, mora em" + Endereco + " e o seu numero de contato é" + Celular + " Sua disciplina atribuida é " + lecionando + " e seu salario sera de: " + salario);

        }


    }
}
