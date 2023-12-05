using Travelator.API.Entities;

namespace Travelator.API.Service
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategorys();
        Task<Category> GetCategory(int id);
        Task<List<Human>> GetHumanCategory(int cId);
    }
}
