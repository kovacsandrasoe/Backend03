using Backend03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend03.Data
{
    public class WorkerRepository
    {
        BurgerDbContext ctx;

        public WorkerRepository(BurgerDbContext ctx)
        {
            this.ctx = ctx;
        }

        public void CreateWorker(Worker w)
        {
            this.ctx.Workers.Add(w);
            this.ctx.SaveChanges();
        }

        public void DeleteWorker(int id)
        {
            var workerToDelete = this.GetWorkerById(id);
            this.ctx.Workers.Remove(workerToDelete);
            this.ctx.SaveChanges();
        }

        public void UpdateWorker(Worker w)
        {
            var oldWorker = this.GetWorkerById(w.Id);
            oldWorker.Name = w.Name;
            this.ctx.SaveChanges();
        }

        public IQueryable<Worker> GetAllWorkers() 
        {
            return this.ctx.Workers;
        }

        public Worker GetWorkerById(int id)
        {
            return this.ctx.Workers.First(w => w.Id == id);
        }
    }
}
