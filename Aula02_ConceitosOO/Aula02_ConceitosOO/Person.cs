using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_ConceitosOO
{
    public class Person : People
    { //um Exemplo de Herança herdando de People =)
        private string _rg;
        private string _cpf;

        private int _idade;

        public string Apelido { protected get; set; }
        public string Rg
        {
            set { _rg = value; }
            get { return _rg; }
        }

        public string Cpf
        {
            set { _cpf = value; }
            get { return _cpf; }
        }

        public int Idade
        {
            set { _idade = value; }
            get { return _idade; }
        }

    }
}
