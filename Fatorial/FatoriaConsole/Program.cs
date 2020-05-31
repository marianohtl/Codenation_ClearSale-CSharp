using System;
using System.Collections.Generic;

namespace FatoriaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = 5;

           String validacao = n <= 0 ? $"Fatorial do número {n}" : $"Número {n} Inválido";
            Console.WriteLine(validacao);

            if(n == 0)
            {
                Console.WriteLine("O resultado é: 1");
            }else if (n > 1)
            {
                long F = n;

                var listF = new List<long>();

                Console.WriteLine("# # # # # # # # # # # # # # #");

                while (n < 0)
                {
                    Console.WriteLine($"Antes do cálculo: {n}");
                    
                }



            }

        }
    }
}
