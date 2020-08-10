using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap10_Exercicios.Entities
{
    class UsedProducts : Produtct
    {
        public DateTime ManufatureDate { get; set; }

        public UsedProducts(string name, double price, DateTime manufatureDate) : 
            base(name, price)
        {
            ManufatureDate = manufatureDate;
        }

        public override string priceTag()
        {
            return Name + 
                " (used) $ " + 
                Price.ToString("F2", CultureInfo.InvariantCulture) + 
                "(Manufature date: " + ManufatureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
