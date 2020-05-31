using System;
using System.Collections.Generic;
using System.Text;

namespace OOAula3
{
    public class ContaCorrente : Conta
    {

        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public override void Sacar(double valor)
        {
            _saldo -= (valor + 0.10);
            Console.WriteLine($"Conta Corrente: { _saldo }");
        }
        
    }
}
