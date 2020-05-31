using System;
using System.Collections.Generic;
using System.Text;

namespace OOAula3
{
    public sealed class ClasseDerivada : ClasseBase
    {
        public ClasseDerivada(){}

        //Temos aqui uma classe selada para vermos que ninguém pode utilizar essa classe como herança
        //Mas observe, que apesar de que ela não possa ser usada como herança, eu posso atribuir herança nela
        public override void ExibirInformações()
        {
            string msg = "Mensagem da Classe Derivada.";

            Console.WriteLine(msg);
        }
    }
}
