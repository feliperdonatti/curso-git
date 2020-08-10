using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap10_Exercicios.Entities
{
    class Produtct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Produtct()
        {
        }

        public Produtct(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
