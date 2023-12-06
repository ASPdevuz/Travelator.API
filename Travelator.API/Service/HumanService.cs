using Microsoft.EntityFrameworkCore;
using Travelator.API.Data;
using Travelator.API.Dtos;
using Travelator.API.Entities;

namespace Travelator.API.Service
{
    public class HumanService : IHumanService
    {
        private readonly AppDbContext dbContext;

        public HumanService(AppDbContext dbContext)
            => this.dbContext = dbContext; 
        public async Task<Human> CreateHuman(CraeteHumanDto newHuman)
        {
            var created = new Human
            {
                Id = Guid.NewGuid(),
                Fullname = newHuman.Fullname,
                Age = newHuman.Age,
                Psp = newHuman.Psp,
                Region = newHuman.Region,
                TicketId = newHuman.TicketId,
                CategoryId = newHuman.CategoryId
            };

            await dbContext.Humans.AddAsync(created);
            await dbContext.SaveChangesAsync();

            return created;
        }

        public async Task<bool> DeleteHuman(Guid id)
        {
            var human = await dbContext.Humans
                .FirstOrDefaultAsync(h => h.Id == id);

            if (human is null)
                return false;

            dbContext.Humans.Remove(human);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Human> GetHuman(Guid id)
        {
            var human = await dbContext.Humans
                .FirstOrDefaultAsync(h => h.Id == id);

            if (human is null)
                return null;

            return human;
        }

        public async Task<List<Human>> GetHumans()
            => await dbContext.Humans.ToListAsync();

        public async Task<Human> UpdateHuman(Guid id, UpdateHumanDto human)
        {
            var updated = await dbContext.Humans
                .FirstOrDefaultAsync(h => h.Id == id);

            if (updated is null)
                return null;

            updated.Fullname = human.Fullname;
            updated.Psp = human.Psp;
            updated.Age = human.Age;
            updated.Region = human.Region;
            updated.TicketId = human.TicketId;
            updated.CategoryId = human.CategoryId;

            await dbContext.SaveChangesAsync();
            return updated;
        }
    }
}
