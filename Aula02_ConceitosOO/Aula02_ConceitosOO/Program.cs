using System;

namespace Aula02_ConceitosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //People people = new People();
            //Person person = new Person();
            //JuridicalPerson personJuridic = new JuridicalPerson();

            
            
            //um Exemplo de Herança herdando de People =)
            

            //O modificador protected me impediu de acessar a classe por aqui
            //person.Nome = "Camila";
            //person.Cpf = "000.0000.000.00";
            //person.Rg = "000.000.000.00";
            //person.Idade = 1;
            //person.Update(person);


            //personJuridic.Nome = "Marcela";
            //personJuridic.CNPJ = "0000.000.0000";
            //personJuridic.InscricaoEstadual = "000000000/0000";
            //personJuridic.Add(person);

            //personJuridic.Endereco = "";

            //person.Apelido = "a";
            //person.Apelido;  => o get não nos permite passar valores


            //people.Nome = "Abacaxi";
            //people.Endereco = "Avenida Randon 322 - São Paulo - SP";



            //people.Cpf = "444.444.444.44";
            //people.Rg = "34.455.678.00";
            //people.Idade = 10;

            //### Segunda Parte da Aula - Polimorfismo

            string nome = "um nome";
            string endereco = "um endereco";

            Pessoa pessoa = new Pessoa(nome, endereco);

            PessoaFisica pessoaFisica = new PessoaFisica(nome, endereco);
            //pessoaFisica.ExibirNome();

            PessoaJuridica pessoaJuridica = new PessoaJuridica("Empresa XPTO", "Rua Random 667");
            //pessoaJuridica.ExibirNome();
            pessoaFisica.Apelido = "batata";

            IPessoaRepository pessoaRepository = new PessoaRepository();
            string apelido = pessoaRepository.RetornarApelido(pessoaFisica);

            Console.WriteLine($"{apelido}");

            Console.ReadKey();

        }

    }
}
