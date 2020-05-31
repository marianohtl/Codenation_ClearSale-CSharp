using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_ConceitosOO
{
    interface IPessoaRepository
    {

        void Create(Pessoa pessoa);
        void Read(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void Delete(Pessoa pessoa);

        string RetornarApelido(PessoaFisica pessoa);
    }
}
