using Travelator.API.Dtos;
using Travelator.API.Entities;

namespace Travelator.API.Service
{
    public interface IHumanService
    {
        Task<List<Human>> GetHumans();
        Task<Human> GetHuman(Guid id);
        Task<Human> CreateHuman(CraeteHumanDto newHuman);
        Task<Human> UpdateHuman(Guid id, UpdateHumanDto human);
        Task<bool> DeleteHuman(Guid id);
    }
}
