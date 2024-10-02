using Backend03.Models;

namespace Backend03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Astoria"),
                new Restaurant(2, "Bécsi út"),
                new Restaurant(3, "Westend")
            };

            var products = new List<Product>
            {
                new Product(1, "Hamburger", 1000, "M"),
                new Product(2, "Cheeseburger", 1200, "M"),
                new Product(3, "Big Mac", 1500, "L"),
                new Product(4, "McRoyal", 1800, "L"),
                new Product(5, "McChicken", 1300, "M"),
                new Product(6, "McFish", 1100, "M"),
            };

            restaurants[0].Products.Add(products[0]);
            restaurants[0].Products.Add(products[1]);
            restaurants[1].Products.Add(products[2]);
            restaurants[1].Products.Add(products[3]);
            restaurants[1].Products.Add(products[4]);
            restaurants[2].Products.Add(products[5]);

            
        }
    }
}
