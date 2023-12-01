using Microsoft.EntityFrameworkCore;
using Travelator.API.Entities;

namespace Travelator.API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Human> Humans { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Human>()
                .HasKey(h => h.Id);
            builder.Entity<Human>()
                .Property(h => h.Fullname)
                .IsRequired()
                .HasMaxLength(100);
            builder.Entity<Human>()
                .Property(h => h.Age)
                .IsRequired();
            builder.Entity<Human>()
                .Property(f => f.Psp)
                .IsRequired();
            builder.Entity<Human>()
                .Property(h => h.Region)
                .IsRequired()
                .HasMaxLength(100);
            builder.Entity<Human>()
                .HasOne(h => h.Ticket)
                .WithMany()
                .HasForeignKey(h => h.TicketId);
            builder.Entity<Ticket>()
                .HasKey(t => t.Id);
            builder.Entity<Ticket>()
                .Property(t => t.Location)
                .IsRequired();
            builder.Entity<Ticket>()
                .Property(t => t.Price)
                .IsRequired();
            builder.Entity<Ticket>()
                .Property(t => t.Time)
                .HasDefaultValue(DateTime.Now);

            base.OnModelCreating(builder);
        }
    }
}
