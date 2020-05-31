using System;

namespace Volei
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeVolei = new VoleiTimePraia();
            var time = timeVolei.GetTime();

            foreach (var item in time)
            {
                Console.WriteLine($"Jogadora: {item.Nome}, Numero: {item.Numero}");
            }
        }
    }
}
