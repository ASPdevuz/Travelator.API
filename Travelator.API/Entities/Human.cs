namespace Travelator.API.Entities
{
    public class Human
    {
        public Guid Id { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Psp { get; set; }
        public string Region { get; set; }
        public int TicketId { get; set; }
        public int CategoryId { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual Category Cateogry { get; set; }
    }
}
