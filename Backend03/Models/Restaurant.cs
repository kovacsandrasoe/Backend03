using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend03.Models
{
    public class Restaurant
    {
        public Restaurant(string name)
        {
            Name = name;
        }

        public Restaurant()
        {
                
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
