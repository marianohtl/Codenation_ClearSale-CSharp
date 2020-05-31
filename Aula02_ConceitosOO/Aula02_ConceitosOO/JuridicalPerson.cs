using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_ConceitosOO
{
    public class JuridicalPerson : People
    {
        private string _cnpj;
        private string _ie;

        public string CNPJ {
            set { _cnpj = value; }
            get { return _cnpj; }
        }

        public string InscricaoEstadual
        {
            set { InscricaoEstadual = _ie; }
            get { return _ie; }
        }

        
    }
}
