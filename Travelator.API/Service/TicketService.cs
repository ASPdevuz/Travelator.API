using Travelator.API.Data;
using Travelator.API.Dtos;
using Travelator.API.Entities;

namespace Travelator.API.Service
{
    public class TicketService : ITicketService
    {
        private readonly AppDbContext dbContext;

        public TicketService(AppDbContext dbContext) 
            => this.dbContext = dbContext;
        public Task<Ticket> CreateTicket(CreateTicketDto newTicket)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTicket(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ticket>> GetTicket()
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetTicket(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> UpdateTicket(UpdateTicketDto ticket)
        {
            throw new NotImplementedException();
        }
    }
}




