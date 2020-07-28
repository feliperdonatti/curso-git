using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //aqui irá ignorar o separador de decimal pt-BR
            //Console.WriteLine("Você digitou o double: " + n2.ToString("F2", CultureInfo.InvariantCulture)); //aqui irá imprimir o double com 2 casas decimais e com o separador de casas decimais como .
            Exercicio32();
        }

        public static void Exercicio23()
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int nroQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha): ");
            string[] str = Console.ReadLine().Split(" ");
            string ultimoNome = str[0];
            int idade = int.Parse(str[1]);
            double altura = double.Parse(str[2], CultureInfo.InvariantCulture);
            Console.WriteLine("{0} {1} {2:F2}", ultimoNome, idade, altura.ToString(CultureInfo.InvariantCulture));

        }

        public static void Exercicio32()
        {
            Console.Write("Digite um nro: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(numero >= 0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

                Console.Write("Digite um outro nro: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            }

        }

    }

}
