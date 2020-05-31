using System;
using System.Collections.Generic;
using System.Text;

namespace OOAula3
{
    public class ContaPoupanca : Conta
    {

        private double _saldo;

        public double Saldo{
        get {return _saldo;}
        set { _saldo = value; }
        }
        public override void Sacar(double valor)
        {
            _saldo -= valor;
            Console.WriteLine($"Conta Poupanca: { _saldo }");

        }
    }
}
