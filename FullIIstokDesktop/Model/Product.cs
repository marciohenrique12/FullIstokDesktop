using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullIIstokDesktop.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Sku { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
        public decimal? Price { get; set; }

        //Contrutor padrão
        public Product()
        {
        }

        //Construtor com argumentos
        public Product(int id, string sku, string name, string description, int quantity, decimal price)
        {
            Id = id;
            Sku = sku;
            Name = name;
            Description = description;
            Quantity = quantity;
            Price = price;
        }
    }


}
