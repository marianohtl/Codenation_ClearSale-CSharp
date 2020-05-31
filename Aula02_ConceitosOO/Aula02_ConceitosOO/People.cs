using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_ConceitosOO
{
    public class People
    {

        private string _nome;

        private string _endereco;


        protected string Nome {
            set { _nome = value; }
            get { return _nome; }
        }

        internal string Endereco
        {
            set { _endereco = value; }
            get { return _endereco; }
        }


        public void Add(People people)
        {
            people.Endereco = "";
        }

        public void Update(People people)
        {

        }

        public void Search(People peope) { }

        public void Remove(People people)
        {

        }
    }
}
