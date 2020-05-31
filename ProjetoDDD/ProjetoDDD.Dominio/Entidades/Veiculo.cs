using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDDD.Dominio.Entidades
{
    public class Veiculo
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public string Imagem { get; set; }
        public int KM { get; set; }
        public double Preco { get; set; }
        public int AnoModelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor { get; set; }
    }
}
