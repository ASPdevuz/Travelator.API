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
        public Task<Human> CreateHuman(CraeteHumanDto newHuman)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHuman(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Human> GetHuman(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Human>> GetHumans()
        {
            throw new NotImplementedException();
        }

        public Task<Human> UpdateHuman(UpdateHumanDto human)
        {
            throw new NotImplementedException();
        }
    }
}
