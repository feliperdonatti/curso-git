using System;

namespace Cap6Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented:");
            int quartos = int.Parse(Console.ReadLine());

            Student[] vec = new Student[10];

            for(int i = 0; i < quartos; i++)
            {
                Console.WriteLine("Room #" + (i + 1));
                Console.Write("Name:");
                string nome = Console.ReadLine();
                Console.Write("Email:");

                string email = Console.ReadLine();
                Console.Write("Room:");

                int room = int.Parse(Console.ReadLine());

                vec[room - 1] = new Student { Name = nome, Email = email, Room = room };
            }

            Console.WriteLine("Busy Rooms:");
            for (int i = 0; i <= 9; i++)
            {
                if (vec[i] != null)
                {
                    Console.WriteLine(vec[i].ToString());
                }
            }
        }
    }
}
