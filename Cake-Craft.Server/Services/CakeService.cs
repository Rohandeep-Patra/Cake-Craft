using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cake_Craft.Server.Data;
using Cake_Craft.Server.Data.Models;
using Cake_Craft.Server.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Cake_Craft.Server.Services
{
    public class CakeService : ICakeService
    {
        private readonly CakeCraftDbContext dbContext;
        public CakeService(CakeCraftDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<Cake>> GetAllCakesAsync()
        {
            return await this.dbContext.Cakes.ToListAsync();
        }
        public async Task<Cake> GetCakeByIdAsync(int cakeId)
        {
            return await this.dbContext.Cakes.FindAsync(id);
        }
        public async Task<bool> AddCakeAsync(Cake cake)
        {
            await this.dbContext.Cakes.AddAsync(cake);
            await this.dbContext.SaveChangesAsync();
        }
        public async Task<bool> UpdateCakeAsync(int cakeId,Cake cake)
        {
            this.dbContext.Cakes.Update(cake);
            await this.dbContext.SaveChangesAsync();
        }
        public async Task<bool> DeleteCakeAsync(int cakeId)
        {
            var cake = await this.GetCakeByIdAsync(id);
            if (cake != null)
            {
                this.dbContext.Cakes.Remove(cake);
                await this.dbContext.SaveChangesAsync();
            }
        }
    }
}