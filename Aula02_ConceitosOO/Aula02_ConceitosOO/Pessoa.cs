using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_ConceitosOO
{
    public class Pessoa
    {

        private string novaPessoa{get;set;}
        private string _nome { get; }

        public string Endereco { get; protected set; }

        protected string apelido;
        public string Nome { get { return _nome; } }


        public Pessoa(string nome, string endereco)
        {
            _nome = nome;
            Endereco = endereco;
        }

 

        public virtual void ExibirNome()
        {
            Console.WriteLine($"Exibir um Nome:{_nome}");
        }


    }
}
