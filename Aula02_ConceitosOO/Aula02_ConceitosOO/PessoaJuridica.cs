using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_ConceitosOO
{
    public class PessoaJuridica : Pessoa
    {
        private string _cnpj;
        private string _ie;

        public string CNPJ {
            get {return _cnpj; }
            set {_cnpj = value; } }

        public string InscricaoEstadual
        {
            get { return _ie; }
            set { _ie = value; }
        }

        public PessoaJuridica (string nome, string endereco):base(nome, endereco){}

        public override void ExibirNome()
        {
            Console.WriteLine($"Pessia Jurídica - Exibir Nome: {Nome}");
        }

    }
}
