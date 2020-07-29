using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered

            };

            Console.WriteLine(order);

            //Converter string para emun
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");


            string txt = OrderStatus.Delivered.ToString();

            Console.WriteLine(os);
            Console.WriteLine(txt);


        }
    }
}
