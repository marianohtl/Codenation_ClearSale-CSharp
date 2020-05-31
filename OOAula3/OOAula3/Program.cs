using System;
using System.Collections.Generic;
using System.Linq;

namespace OOAula3
{
    class Program
    {
        static void Main(string[] args)
        {   // Não permite criar um objeto a partir de uma classe abstrata
            //Conta conta = new Conta();

            ClasseBase classeBase = new ClasseBase();
            ClasseDerivada classeDerivada = new ClasseDerivada();

            ContaCorrente contaCorrente = new ContaCorrente();
            ContaPoupanca contaPoupanca = new ContaPoupanca();

            contaCorrente.Saldo = 5000.34;
            contaPoupanca.Saldo = 345.23;

            contaCorrente.Sacar(40.5);
            contaPoupanca.Sacar(10.4);
            classeBase.ExibirInformações();
            classeDerivada.ExibirInformações();

            Dados dados = new Dados();



            //trabalhando com Retorno do IEnuberable >>> 
            //IEnumerable<Veiculo> dadosEnumerable = dados.RetornarIEnuberable();

            //var query = dadosEnumerable.Where(a =>a.AnoFabricacao <2000);
            //var query = dadosEnumerable.Where(a =>a.Nome.Contains("a"));
            //var query = dadosEnumerable.Where(a =>a.Id == 2);

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Veículo do IEnurable  - Nome: {item.Id}");
            //    Console.WriteLine($"Veículo do IEnurable  - Nome: {item.Nome}");
            //    Console.WriteLine($"Veículo do IEnurable  - Nome: {item.Marca}");
            //    Console.WriteLine($"Veículo do IEnurable  - Nome: {item.AnoFabricacao}");

            //}



            //trabalhando com o retorno de colections 
            //ICollection<Veiculo> dadosColection = dados.RetornarICollectionFromIEnumerable();


            //essa query retona todos que tenham a , porem o tostring torna tudo da lista em maiúsculo
            //var query = dadosColection.Where(a => a.Nome.ToUpper().Contains("a"));

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Veículo do IEnurable  - Id: {item.Id}");
            //    Console.WriteLine($"Veículo do IEnurable  - Nome: {item.Nome}");
            //    Console.WriteLine($"Veículo do IEnurable  - Marca: {item.Marca}");
            //    Console.WriteLine($"Veículo do IEnurable  - Ano Fabricação: {item.AnoFabricacao}");

            //}



            //trabalhando com o retorno de colections 
            //var dadosList = dados.RetornarList();


            //var query = dadosList.Where(a => a.Id > 1);

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Veículo do IEnurable  - Id: {item.Id}");
            //    Console.WriteLine($"Veículo do IEnurable  - Nome: {item.Nome}");
            //    Console.WriteLine($"Veículo do IEnurable  - Marca: {item.Marca}");
            //    Console.WriteLine($"Veículo do IEnurable  - Ano Fabricação: {item.AnoFabricacao}");

            //}
            //var dadosList = dados.RetornarDictionary();


            //foreach (var item in dadosList)
            //{
            //    Console.WriteLine($"Veículo do IEnurable  - Id: {item.Key} e {item.Value}");

            //}


            //var dadosList = dados.RetornarDictionaryVeiculo();


            //foreach (var item in dadosList)
            //{
            //    Console.WriteLine($"Veículo do IEnurable  - Id: {item.Key} e {item.Value.Id} {item.Value.Nome} {item.Value.Marca} {item.Value.AnoFabricacao}");

            //}


            var dadosIEnuberable = dados.RetornarIEnuberable();
            var dadosCollection = dados.RetornaCollection();
            var dadosList = dados.RetornarList();
            var dadosDictionary = dados.RetornarDictionaryVeiculo();


            var veiculo = new Veiculo
            {
                Id = 6,
                Nome = "lalalal",
                AnoFabricacao = 202020
            };

            //tipo coleção IEnuberable não permite adicionar novo objeto 

            dadosCollection.Add(veiculo);
            dadosList.Add(veiculo);
            dadosDictionary.Add(5,veiculo);



            //array
            string[] nomes = new string[3];
            nomes[0] = "Maria";
            nomes[1] = "Joao";
            nomes[2] = "Bia";

            Console.ReadKey();
        }
    }
}
