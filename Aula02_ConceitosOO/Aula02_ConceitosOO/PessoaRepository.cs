using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_ConceitosOO
{
    class PessoaRepository : IPessoaRepository
    {
        public void Create(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void Delete(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void Read(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void Update(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
        public string RetornarApelido(PessoaFisica pessoa)
        {
            return pessoa.Apelido;
        }

    }
}
