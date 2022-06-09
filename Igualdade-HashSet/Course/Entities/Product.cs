using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Product
    {
        public string Nome { get; set; }
        public double Price { get; set; }

        public Product(string nome, double price)
        {
            Nome = nome;
            Price = price;

        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }
            // Fazendo downcasting
            Product other = obj as Product;
            return Nome.Equals(other.Nome) && Price.Equals(other.Price);
        }
    }
}
