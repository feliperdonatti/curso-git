using System;
using System.Globalization;

namespace Cap5Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o nro da conta:");
            int nroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta:");
            string titular = Console.ReadLine().ToUpper();

            Console.Write("Haverá deposito inicial (S/N):");
            char deposito = char.Parse(Console.ReadLine().ToUpper());

            if (deposito == 'S')
            {
                 
                Console.Write("Entre com o valor de deposito inicial:");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nroConta, titular, saldoInicial);

            } else
            {
                conta = new ContaBancaria(nroConta, titular);

            }





        }
    }
}
