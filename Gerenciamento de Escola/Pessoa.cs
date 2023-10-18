using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{
    internal class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private int celular;
        public int Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public Pessoa(string nome, int idade, string endereco, int celular)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
            this.celular = celular;
        }

        public void InfoPessoa()
        {
            Console.WriteLine(" Seu nome é " + nome + " você tem " + idade + " anos, mora em " + endereco + " e seu numero de contato é " + celular);
        }

    }



}
