using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManifactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manifactureDate) : base (name, price)
        {
            ManifactureDate = manifactureDate;
        }

        public override string PriceTag()
        {
            return Name + "(used) $ " + Price
                + " (Manufacture date: " + ManifactureDate.ToString("dd/MM/yyyy")
                + ")";
            
        }
    }
}
