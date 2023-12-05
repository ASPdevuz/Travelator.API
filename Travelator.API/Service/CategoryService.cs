using Travelator.API.Data;
using Travelator.API.Entities;

namespace Travelator.API.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext dbContext;

        public CategoryService(AppDbContext dbContext) 
            => this.dbContext = dbContext;
        public Task<Category> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategorys()
        {
            throw new NotImplementedException();
        }

        public Task<List<Human>> GetHumanCategory(int cId)
        {
            throw new NotImplementedException();
        }
    }
}



