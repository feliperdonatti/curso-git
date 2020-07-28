using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap5Exercicio1
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroConta, string titular, double valor) : this(numeroConta, titular)
        {
            Deposita(valor);
        }

        public void Deposita(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + Titular + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
