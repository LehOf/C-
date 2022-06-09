using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product produto { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int Quantity, double Price, Product produto)
        {
            this.Quantity = Quantity;
            this.Price = Price;
            this.produto = produto;

        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return produto.Name
            +", $" + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
