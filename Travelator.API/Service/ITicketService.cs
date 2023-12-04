using Travelator.API.Dtos;
using Travelator.API.Entities;

namespace Travelator.API.Service
{
    public interface ITicketService
    {
        Task<List<Ticket>> GetTicket();
        Task<Ticket> GetTicket(Guid id);
        Task<Ticket> CreateTicket(CreateTicketDto newTicket);
        Task<Ticket> UpdateTicket(UpdateTicketDto ticket);
        Task<bool> DeleteTicket(Guid id);
    }
}
