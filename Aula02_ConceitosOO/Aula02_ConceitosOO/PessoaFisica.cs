using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_ConceitosOO
{
    public class PessoaFisica : Pessoa
    {
        private string _rg;
        private string _cpf;

        public string RG { get { return _rg ; } set { _rg = value; } }
        public string CPF { get { return _cpf ; } set { _cpf = value; } }

        //está protegido diantes das outras classes, porém podemos acessar por meio do protected
        public string Apelido { get { return apelido ; } set { apelido = value; } }

        // impossíve acessar o atributo , pois é privado
        // public string NovaPessoa { get { return novaPessoa; } set { novaPessoa = value; } }
        public PessoaFisica(string nome, string endereco) : base(nome, endereco){}

        public override void ExibirNome()
        {
            base.ExibirNome();
        }

    }
}
