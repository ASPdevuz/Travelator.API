namespace Travelator.API.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public double Price { get; set; }
        public DateTime Time { get; set; }
    }
}
