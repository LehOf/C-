using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace restricoesGenerics.entities
{
    class Product : IComparable
    {
        public string Nome { get; set; }
        public double Price { get; set; }

        public Product(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                + "Price: " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not an Product");
            }
            // Comparando os produtos pelo preço
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
