using System;
using System.Collections.Generic;
using System.Text;

namespace Volei
{
    public class Jogadora
    {
        public string Nome { get; set; }

        public int Numero { get; set; }


        public Jogadora(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        }
    }
}
