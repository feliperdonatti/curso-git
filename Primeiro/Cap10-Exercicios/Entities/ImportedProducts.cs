using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Transactions;

namespace Cap10_Exercicios.Entities
{
    class ImportedProducts : Produtct
    {
        public double CustomsFee { get; set; }

        public ImportedProducts(string name, double price, double customsFee) :
            base(name, price)
        {
            CustomsFee = customsFee;
        }

        private double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string priceTag()
        {
            return Name

                            + " $ "

                            + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)

                            + " (Customs fee: $ "

                            + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)

                            + ")";
        }
    }
}
