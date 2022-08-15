using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LegateAirLine.Models
{
    public class ApplicationDbcontext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext>options):base(options)
        {

        }
      /*  protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Bag>()
            .HasOne(t => t.Traveler)
            .WithMany(b => b.Bags)
            .HasForeignKey(b => new { b.TravelerCode, b.TravelerId })
            .HasPrincipalKey(t => new { t.FirstName, t.LastName });
        }*/

        public DbSet<TicketTrip> Trips { get; set; }
        public DbSet<Traveler> Travelers { get; set; }
        public DbSet<Bag> Bags { get; set; }

    }
}
