using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uou
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor1 = 30;
            decimal valor2 = 7;

            //int soma = valor1 + valor2;
            //int subtracao = valor1 + valor2;
            decimal div = valor1 / valor2;

           // Console.WriteLine($"O valor da soma é {soma}");
            //Console.WriteLine($"O valor da subtração é {subtracao}");
            Console.WriteLine($"O valor da divisão é {div}");
            int ii = 1;
            String[]  list = { "a", "b", "c", "d" };
            foreach (String item in list)
            {
                Console.WriteLine($"Item {ii}: {item}");
                ii += 1;

            }


            for (int i = 1; i < 10; i++) { 
                Console.WriteLine($"Valor do i = {i}");
            }

            int cont = 1;

            while(cont < 10)
            {
                Console.WriteLine($"Valor do cont = {cont}");
                cont += 1;

            }


            Console.ReadKey();

        }
    }
}
