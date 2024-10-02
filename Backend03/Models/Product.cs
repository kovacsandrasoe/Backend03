using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend03.Models
{
    public class Product
    {
        public Product(int id, string name, int price, string size)
        {
            Id = id;
            Name = name;
            Price = price;
            Size = size;
        }

        public Product()
        {
            
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Size { get; set; }

        public Restaurant Restaurant { get; set; }

    }
}
