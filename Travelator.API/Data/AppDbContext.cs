using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
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
            builder.Entity<Human>()
                .HasOne(h => h.Cateogry)
                .WithMany()
                .HasForeignKey(h => h.CategoryId)
                .IsRequired();
            builder.Entity<Category>()
                .HasKey(c => c.Id);
            builder.Entity<Category>()
                .Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder.Entity<Category>()
                .HasData(
                    new { Id = 1, Name = "Davrli reyslar" },
                    new { Id = 2, Name = "Tarif reyslar" },
                    new { Id = 3, Name = "Xalqaro reyslar" },
                    new { Id = 4, Name = "Transiti reyslar" },
                    new { Id = 5, Name = "Chaqqon reyslar" }
                );

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
