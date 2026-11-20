using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Service_Request_and_Maintenance_Ticketing_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Service_Request_and_Maintenance_Ticketing_System.Model.TicketCategory> TicketCategory { get; set; } = default!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
