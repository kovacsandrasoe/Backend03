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

            var workers = new List<Worker>
            {
                new Worker("John Doe"),
                new Worker("Jane Doe"),
                new Worker("Jack Doe"),
                new Worker("Jill Doe")
            };

            restaurants[0].Products.Add(products[0]);
            restaurants[0].Products.Add(products[1]);
            restaurants[0].Products.Add(products[2]);
            restaurants[1].Products.Add(products[2]);
            restaurants[1].Products.Add(products[3]);
            restaurants[1].Products.Add(products[4]);
            restaurants[2].Products.Add(products[4]);
            restaurants[2].Products.Add(products[5]);

            restaurants[0].Workers.Add(workers[0]);
            restaurants[1].Workers.Add(workers[1]);
            restaurants[2].Workers.Add(workers[2]);
            restaurants[2].Workers.Add(workers[3]);

            ctx.Workers.AddRange(workers);
            ctx.Products.AddRange(products);
            ctx.Restaurants.AddRange(restaurants);
            ctx.SaveChanges();

            var res = ctx.Restaurants
                .Include(r => r.Workers)
                .Include(t => t.Products).ToList();

            
            var repo = new WorkerRepository(ctx);

            //create
            var paul = new Worker("Paul Newman");
            paul.RestaurantId = 2;
            repo.CreateWorker(paul);

            //update
            var upd = repo.GetWorkerById(1);
            upd.Name = "Johnny Doe";
            repo.UpdateWorker(upd);

            //delete
            repo.DeleteWorker(5);

            //read
            var names = repo.GetAllWorkers()
                .Select(w => w.Name)
                .ToList();

            




        }
    }
}
