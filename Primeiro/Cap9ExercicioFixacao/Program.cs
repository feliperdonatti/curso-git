using Cap9ExercicioFixacao.Entities;
using Cap9ExercicioFixacao.Entities.Enum;
using System;

namespace Cap9ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");

            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("E-mail:");
            string email = Console.ReadLine();

            Console.WriteLine("Birth Date (DD/MM/YYYY):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");

            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());




        }
    }
}
