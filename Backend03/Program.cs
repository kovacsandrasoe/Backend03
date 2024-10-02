using Backend03.Data;
using Backend03.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ctx = new BurgerDbContext();

            var restaurants = new List<Restaurant>
            {
                new Restaurant("Astoria"),
                new Restaurant("Bécsi út"),
                new Restaurant("Westend")
            };

            var products = new List<Product>
            {
                new Product("Hamburger", 1000, "M"),
                new Product("Cheeseburger", 1200, "M"),
                new Product("Big Mac", 1500, "L"),
                new Product("McRoyal", 1800, "L"),
                new Product("McChicken", 1300, "M"),
                new Product("McFish", 1100, "M"),
            };

            restaurants[0].Products.Add(products[0]);
            restaurants[0].Products.Add(products[1]);
            restaurants[0].Products.Add(products[2]);
            restaurants[1].Products.Add(products[2]);
            restaurants[1].Products.Add(products[3]);
            restaurants[1].Products.Add(products[4]);
            restaurants[2].Products.Add(products[4]);
            restaurants[2].Products.Add(products[5]);


            ctx.Products.AddRange(products);
            ctx.Restaurants.AddRange(restaurants);
            ctx.SaveChanges();

            var res = ctx.Restaurants
                .Include(t => t.Products).ToList();

            ;
        }
    }
}
