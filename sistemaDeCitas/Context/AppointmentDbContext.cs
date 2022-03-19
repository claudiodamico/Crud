using Microsoft.EntityFrameworkCore;
using sistemaDeCitas.Models;

namespace sistemaDeCitas.Context
{
    public class AppointmentDbContext : DbContext
    {
        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options) : base(options)
        {

        }

        public DbSet<Appointment> appointments { get; set; }
    }
}
