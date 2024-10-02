using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend03.Models
{
    public class Product
    {
        public Product(string name, int price, string size)
        {
            Name = name;
            Price = price;
            Size = size;
        }

        public Product()
        {
            
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Size { get; set; }

        //public Restaurant Restaurant { get; set; }

        //public int RestaurantId { get; set; }

        public List<Restaurant> Restaurants { get; set; } 
            = new List<Restaurant>();
    }
}
