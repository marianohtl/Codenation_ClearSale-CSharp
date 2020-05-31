using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace OOAula3
{
    public class Dados
    {

        // IEnumerable<Veiculo> Reror
        //public IList<Veiculo> RetornarList()
        //{

           


        private IDictionary<int, string> CargaExDictionary()
        {
            IDictionary<int, string> valores = new Dictionary<int, string>
                {
                    { 1,"Maria"}
                };
            return valores;
        }

        public IEnumerable<Veiculo> RetornarIEnuberableFromCollection()
        {
            IEnumerable<Veiculo> carros = CargaExemploCollection().OrderBy(x => x.Nome);
            return carros;
        }

        public IEnumerable<Veiculo> RetornarIEnuberable()
        {
            IEnumerable<Veiculo> carros = CargaExemploEnumerable().OrderBy(x => x.Nome);
            return carros;
        }


        public ICollection<Veiculo> RetornarICollectionFromIEnumerable()
        {
            // ICollection<Veiculo> carros = CargaExemploEnumerable(); error por conta da hierarquia
            ICollection<Veiculo> carros = CargaExemploEnumerable().ToList();
            return carros;
        }

        public ICollection<Veiculo> RetornaCollection()
        {
            return CargaExemploCollection().OrderBy(X => X.Nome).ToList();
        }

        public IList<Veiculo> RetornarList()
        {
            List<Veiculo> carros = CargaExemploList().OrderBy(x => x.Marca).ToList();
            return carros;
        }


        public IDictionary<int, string> RetornarDictionary()
        {
            var dados = CargaExDictionary();
            return dados;
        }

        public IDictionary<int, Veiculo> RetornarDictionaryVeiculo()
        {
            var dados = CargaExploDictionaryClasseVeiculo();
            return dados;
        }


        private ICollection<Veiculo> CargaExemploCollection()
        {
            ICollection<Veiculo> carros = new Collection<Veiculo> {
            new Veiculo {Id = 1, Nome = "aa", Marca = "AA", AnoFabricacao = 20000 },
            new Veiculo {Id = 2, Nome = "aa", Marca = "AA", AnoFabricacao = 20000 },
            new Veiculo { Id = 3, Nome = "aa", Marca = "AA", AnoFabricacao = 20000 }
            };
            return carros;
        }
        private IEnumerable<Veiculo> CargaExemploEnumerable()
        {
            IList<Veiculo> carros = new List<Veiculo>();
            carros.Add(new Veiculo { Id = 1, Nome = "aa", Marca = "AA", AnoFabricacao = 20000 });
            carros.Add(new Veiculo { Id = 2, Nome = "bb", Marca = "BB", AnoFabricacao = 10000 });
            carros.Add(new Veiculo { Id = 3, Nome = "cc", Marca = "CC", AnoFabricacao = 10000 });
            return carros;
        }

        private IList<Veiculo> CargaExemploList()
        {
            IList<Veiculo> carros = new List<Veiculo>();
            carros.Add(new Veiculo { Id = 1, Nome = "a", Marca = "A", AnoFabricacao = 2000 });
            carros.Add(new Veiculo { Id = 2, Nome = "b", Marca = "B", AnoFabricacao = 1000 });
            carros.Add(new Veiculo { Id = 3, Nome = "c", Marca = "C", AnoFabricacao = 1000 });
            return carros;
        }

         private IDictionary<int, Veiculo> CargaExploDictionaryClasseVeiculo() {
            IDictionary<int, Veiculo> valores = new Dictionary<int, Veiculo>
            {
                { 1,new Veiculo{ Id = 1, Nome = "A",Marca="A", AnoFabricacao=2000} }
            };
            return valores;
          }
    }
}
