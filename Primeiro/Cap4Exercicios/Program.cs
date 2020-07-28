using System;
using System.Globalization;

namespace Cap4Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade:");
            p1.Idade = int.Parse(Console.ReadLine());

            Pessoa p2 = new Pessoa();
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade:");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            } else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");

            }

            Funcionario f1 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome:");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario:");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario f2 = new Funcionario();
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome:");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario:");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine($"Salario Médio: {media.ToString("F2", CultureInfo.InvariantCulture)}");



        }
    }
}
