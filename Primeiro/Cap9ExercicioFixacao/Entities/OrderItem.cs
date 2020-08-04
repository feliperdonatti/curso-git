using System;
using System.Collections.Generic;
using System.Text;

namespace Cap9ExercicioFixacao.Entities
{
    class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
