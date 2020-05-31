using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDDD.Dominio.Entidades
{
    public class Versao
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ModeloID { get; set; }
    }
}
