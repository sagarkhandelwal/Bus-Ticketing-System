using BusFinal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BusFinal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

       

        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
    }
}
